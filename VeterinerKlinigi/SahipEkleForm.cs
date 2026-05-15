using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using VeterinerKlinigi.DataAccess;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi
{
    public partial class SahipEkleForm : Form
    {
        private readonly SahipDAL _sahipDal = new();
        private string _secilenDosyaYolu = string.Empty;
        private const string VarsayilanResimDosyaAdi = "default.png";

        public SahipEkleForm()
        {
            InitializeComponent();

            FormBorderStyle = FormBorderStyle.Sizable;
            MaximizeBox = true;
            MinimizeBox = true;
            StartPosition = FormStartPosition.CenterParent;

            ThemeHelper.Uygula(this);

            ClientSize = new Size(620, 241);
            MinimumSize = new Size(620, 280);

            var varsayilanYol = Path.Combine(Application.StartupPath, "Images", VarsayilanResimDosyaAdi);
            if (File.Exists(varsayilanYol))
            {
                pbProfil.ImageLocation = varsayilanYol;
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Filter = "Resim Dosyaları|*.jpg;*.jpeg;*.png",
                Title = "Profil Resmi Seçin"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _secilenDosyaYolu = ofd.FileName;
                pbProfil.ImageLocation = _secilenDosyaYolu;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad zorunludur.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAd.Focus();
                return;
            }

            try
            {
                var profilResmiDosyaAdi = VarsayilanResimDosyaAdi;

                if (!string.IsNullOrWhiteSpace(_secilenDosyaYolu))
                {
                    profilResmiDosyaAdi = ResmiKopyala(_secilenDosyaYolu);
                }

                var sahip = new Sahip
                {
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    CezaPuani = 0,
                    ProfilResmi = profilResmiDosyaAdi
                };

                var yeniId = _sahipDal.SahipEkle(sahip);

                if (yeniId > 0)
                {
                    MessageBox.Show("Kayıt başarıyla eklendi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Kayıt eklenemedi.", "Uyarı",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Dosya kopyalama hatası: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanı hatası: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen hata: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string ResmiKopyala(string kaynakDosyaYolu)
        {
            var uzanti = Path.GetExtension(kaynakDosyaYolu);
            var yeniDosyaAdi = Guid.NewGuid() + uzanti;

            var hedefKlasor = Path.Combine(Application.StartupPath, "Images");
            if (!Directory.Exists(hedefKlasor))
            {
                Directory.CreateDirectory(hedefKlasor);
            }

            var hedefDosyaYolu = Path.Combine(hedefKlasor, yeniDosyaAdi);
            File.Copy(kaynakDosyaYolu, hedefDosyaYolu);

            return yeniDosyaAdi;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void lblProfil_Click(object sender, EventArgs e)
        {

        }
    }
}
