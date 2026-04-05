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
            ThemeHelper.Uygula(this, sidebarEkle: true);
            GridiAyarla();
            SahipleriListele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            SahipleriListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using var form = new SahipEkleForm();
            var sonuc = form.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                SahipleriListele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvSahipler.CurrentRow?.DataBoundItem is not Sahip seciliSahip)
            {
                MessageBox.Show("Lütfen silinecek kaydý seçin.");
                return;
            }

            var onay = MessageBox.Show(
                "Seçili sahip silinsin mi?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (onay != DialogResult.Yes)
            {
                return;
            }

            var silindi = _sahipDal.SahipSil(seciliSahip.SahipId);

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

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            var aranan = txtAra.Text.Trim();

            if (string.IsNullOrWhiteSpace(aranan))
            {
                SahipleriListele();
                return;
            }

            dgvSahipler.DataSource = _sahipDal.SahipAra(aranan);
        }

        private void SahipleriListele()
        {
            dgvSahipler.DataSource = null;
            dgvSahipler.DataSource = _sahipDal.TumSahipleriGetir();
        }

        private void GridiAyarla()
        {
            dgvSahipler.AutoGenerateColumns = false;
            dgvSahipler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSahipler.MultiSelect = false;
            dgvSahipler.ReadOnly = true;
            dgvSahipler.AllowUserToAddRows = false;
            dgvSahipler.AllowUserToDeleteRows = false;
            dgvSahipler.RowHeadersVisible = false;
            dgvSahipler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvSahipler.Columns.Count > 0)
            {
                return;
            }

            dgvSahipler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSahipId",
                HeaderText = "Sahip Id",
                DataPropertyName = "SahipId"
            });

            dgvSahipler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colAd",
                HeaderText = "Ad",
                DataPropertyName = "Ad"
            });

            dgvSahipler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSoyad",
                HeaderText = "Soyad",
                DataPropertyName = "Soyad"
            });

            dgvSahipler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTelefon",
                HeaderText = "Telefon",
                DataPropertyName = "Telefon"
            });

            dgvSahipler.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCezaPuani",
                HeaderText = "Ceza Puaný",
                DataPropertyName = "CezaPuani"
            });
        }

        private void dgvSahipler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            var seciliSatir = dgvSahipler.Rows[e.RowIndex];
            var secilenId = Convert.ToInt32(seciliSatir.Cells["colSahipId"].Value);

            using var form = new SahipGuncelleForm(secilenId);
            var sonuc = form.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                SahipleriListele();
            }
        }
    }
}
