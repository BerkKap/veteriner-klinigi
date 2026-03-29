using System.Drawing;
using System.IO;

namespace VeterinerKlinigi
{
    public partial class GirisForm : Form
    {
        private const string SabitKullaniciAdi = "admin";
        private const string SabitSifre = "12345";
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

            if (kullaniciAdi == SabitKullaniciAdi && sifre == SabitSifre)
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

        private void btnGosterGizle_Click(object sender, EventArgs e)
        {
            _sifreGorunurMu = !_sifreGorunurMu;
            txtSifre.PasswordChar = _sifreGorunurMu ? '\0' : '●';
            btnGosterGizle.Text = _sifreGorunurMu ? "🙈" : "👁";
        }
    }
}