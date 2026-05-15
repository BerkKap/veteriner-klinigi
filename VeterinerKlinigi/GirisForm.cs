using System;
using System.IO;
using System.Windows.Forms;
using VeterinerKlinigi.DataAccess;

namespace VeterinerKlinigi
{
    public partial class GirisForm : Form
    {
        private bool _sifreGorunurMu;

        public GirisForm()
        {
            InitializeComponent();
            AcceptButton = btnGiris;
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            var kullaniciAdi = txtKullaniciAdi.Text.Trim();
            var sifre = txtSifre.Text;

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifre girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var dal = new KullaniciDAL();
                var kullanici = dal.GirisYap(kullaniciAdi, sifre);

                if (kullanici != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                    return;
                }

                MessageBox.Show("Kullanıcı adı veya şifre hatalı.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSifre.Clear();
                txtSifre.Focus();
            }
            catch (Exception ex)
            {
                // Veritabanı veya diğer beklenmeyen hataları logla ve kullanıcıyı bilgilendir
                Logger.LogHata(ex);
                MessageBox.Show("Giriş sırasında bir hata oluştu. Hata detayları 'Logs' klasörüne kaydedildi.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGosterGizle_Click(object sender, EventArgs e)
        {
            _sifreGorunurMu = !_sifreGorunurMu;
            txtSifre.PasswordChar = _sifreGorunurMu ? '\0' : '●';
            btnGosterGizle.Text = _sifreGorunurMu ? "🙈" : "👁";
        }
    }
}