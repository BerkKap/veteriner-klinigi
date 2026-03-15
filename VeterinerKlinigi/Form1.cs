using VeterinerKlinigi.DataAccess;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi
{
    public partial class Form1 : Form
    {
        private readonly SahipDAL _sahipDal = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            SahipleriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad zorunludur.");
                return;
            }

            var sahip = new Sahip
            {
                Ad = txtAd.Text.Trim(),
                Soyad = txtSoyad.Text.Trim(),
                Telefon = txtTelefon.Text.Trim()
            };

            _sahipDal.SahipEkle(sahip);
            SahipleriListele();

            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvSahipler.CurrentRow is null)
            {
                MessageBox.Show("Lütfen silinecek kaydý seçin.");
                return;
            }

            var sahipId = Convert.ToInt32(dgvSahipler.CurrentRow.Cells["SahipId"].Value);

            var onay = MessageBox.Show(
                "Seçili sahip silinsin mi?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (onay != DialogResult.Yes)
            {
                return;
            }

            var silindi = _sahipDal.SahipSil(sahipId);

            if (silindi)
            {
                MessageBox.Show("Kayýt silindi.");
                SahipleriListele();
            }
            else
            {
                MessageBox.Show("Silme iþlemi baþarýsýz.");
            }
        }

        private void SahipleriListele()
        {
            dgvSahipler.DataSource = null;
            dgvSahipler.DataSource = _sahipDal.TumSahipleriGetir();
        }
    }
}
