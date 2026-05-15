using System.IO;
using Microsoft.Data.SqlClient;
using VeterinerKlinigi.DataAccess;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi
{
    public partial class SahipGuncelleForm : Form
    {
        private readonly SahipDAL _sahipDal = new();
        private readonly int _secilenSahipId;
        private string _profilResmiDosyaAdi = "default.png";
        private string _secilenDosyaYolu = string.Empty;
        private int _cezaPuani = 0;
        private const string VarsayilanResimDosyaAdi = "default.png";

        public SahipGuncelleForm(int sahipId)
        {
            InitializeComponent();
            _secilenSahipId = sahipId;
            ThemeHelper.Uygula(this);
        }

        private void SahipGuncelleForm_Load(object sender, EventArgs e)
        {
            var sahip = _sahipDal.GetById(_secilenSahipId);

            if (sahip is null)
            {
                MessageBox.Show("Kayýt bulunamadý.");
                Close();
                return;
            }

            txtAd.Text = sahip.Ad;
            txtSoyad.Text = sahip.Soyad;
            txtTelefon.Text = sahip.Telefon;

            // Ceza puanýný UI'dan kaldýrdýk; mevcut deðeri sakla
            _cezaPuani = sahip.CezaPuani;

            _profilResmiDosyaAdi = string.IsNullOrWhiteSpace(sahip.ProfilResmi)
                ? VarsayilanResimDosyaAdi
                : sahip.ProfilResmi;

            ProfilResminiGoster(_profilResmiDosyaAdi);
        }

        private void ProfilResminiGoster(string dosyaAdi)
        {
            var imagesKlasoru = Path.Combine(Application.StartupPath, "Images");
            var resimYolu = Path.Combine(imagesKlasoru, dosyaAdi);
            var varsayilanYol = Path.Combine(imagesKlasoru, VarsayilanResimDosyaAdi);

            if (File.Exists(resimYolu))
            {
                pbProfil.ImageLocation = resimYolu;
            }
            else if (File.Exists(varsayilanYol))
            {
                pbProfil.ImageLocation = varsayilanYol;
            }
            else
            {
                pbProfil.ImageLocation = null;
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Filter = "Resim Dosyalarý|*.jpg;*.jpeg;*.png",
                Title = "Profil Resmi Seçin"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _secilenDosyaYolu = ofd.FileName;
                pbProfil.ImageLocation = _secilenDosyaYolu;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad zorunludur.");
                return;
            }

            try
            {
                // Eðer kullanýcý yeni bir resim seçtiyse, uygulama klasörüne kopyala ve dosya adýný kullan
                if (!string.IsNullOrWhiteSpace(_secilenDosyaYolu))
                {
                    _profilResmiDosyaAdi = ResmiKopyala(_secilenDosyaYolu);
                }

                var guncelSahip = new Sahip
                {
                    SahipId = _secilenSahipId,
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    CezaPuani = _cezaPuani,
                    ProfilResmi = _profilResmiDosyaAdi
                };

                var basarili = _sahipDal.SahipGuncelle(guncelSahip);

                if (basarili)
                {
                    MessageBox.Show("Kayýt güncellendi.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Güncelleme baþarýsýz.");
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show("Dosya kopyalama hatasý: " + ex.Message);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabaný hatasý: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen hata: " + ex.Message);
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

        private void btnSil_Click(object sender, EventArgs e)
        {
            var secim = MessageBox.Show(
                "Bu kaydý silmek istediðinize emin misiniz?\nBu iþlem geri alýnamaz.",
                "Silme Onayý",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (secim != DialogResult.Yes)
            {
                return;
            }

            try
            {
                var silindi = _sahipDal.SahipSil(_secilenSahipId);

                if (silindi)
                {
                    MessageBox.Show("Kayýt silindi.");
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Silme iþlemi baþarýsýz.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabaný hatasý: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen hata: " + ex.Message);
            }
        }
    }
}