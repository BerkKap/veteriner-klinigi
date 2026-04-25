using System.IO;
using VeterinerKlinigi.DataAccess;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi
{
    public partial class HayvanListesiForm : Form
    {
        private readonly HayvanDAL _hayvanDal = new();

        public HayvanListesiForm()
        {
            InitializeComponent();
            ThemeHelper.Uygula(this);

            ClientSize = new Size(1080, 430);
            MinimumSize = new Size(1080, 470);

            GridiAyarla();
            HayvanlariListele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            HayvanlariListele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            using var form = new HayvanEkleForm();
            var sonuc = form.ShowDialog();

            if (sonuc == DialogResult.OK)
            {
                HayvanlariListele();
            }
        }

        private void HayvanlariListele()
        {
            dgvHayvanlar.DataSource = null;
            dgvHayvanlar.DataSource = _hayvanDal.GetAllDetayli();

            if (dgvHayvanlar.Rows.Count > 0 &&
                dgvHayvanlar.Rows[0].DataBoundItem is HayvanDetayDTO dto)
            {
                SahipResminiGoster(dto.ProfilResmi);
            }
            else
            {
                SahipResminiGoster("default.png");
            }
        }

        private void dgvHayvanlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHayvanlar.CurrentRow?.DataBoundItem is not HayvanDetayDTO dto)
            {
                return;
            }

            SahipResminiGoster(dto.ProfilResmi);
        }

        private static string VarsayilanResimYolu()
        {
            return Path.Combine(Application.StartupPath, "Images", "default.png");
        }

        private void SahipResminiGoster(string? dosyaAdi)
        {
            var imagesKlasoru = Path.Combine(Application.StartupPath, "Images");
            var secilenDosyaAdi = string.IsNullOrWhiteSpace(dosyaAdi) ? "default.png" : dosyaAdi;
            var resimYolu = Path.Combine(imagesKlasoru, secilenDosyaAdi);
            var varsayilanYol = VarsayilanResimYolu();

            if (File.Exists(resimYolu))
            {
                pbSahipProfil.ImageLocation = resimYolu;
            }
            else if (File.Exists(varsayilanYol))
            {
                pbSahipProfil.ImageLocation = varsayilanYol;
            }
            else
            {
                pbSahipProfil.ImageLocation = null;
            }
        }

        private void GridiAyarla()
        {
            dgvHayvanlar.AutoGenerateColumns = false;
            dgvHayvanlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHayvanlar.MultiSelect = false;
            dgvHayvanlar.ReadOnly = true;
            dgvHayvanlar.AllowUserToAddRows = false;
            dgvHayvanlar.AllowUserToDeleteRows = false;
            dgvHayvanlar.RowHeadersVisible = false;
            dgvHayvanlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvHayvanlar.Columns.Count > 0)
            {
                return;
            }

            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colHayvanId",
                HeaderText = "Hayvan Id",
                DataPropertyName = "HayvanId"
            });

            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colHayvanAdi",
                HeaderText = "Ad",
                DataPropertyName = "HayvanAdi"
            });

            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colTur",
                HeaderText = "Tür",
                DataPropertyName = "Tur"
            });

            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colCins",
                HeaderText = "Cins",
                DataPropertyName = "Cins"
            });

            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSahipAdSoyad",
                HeaderText = "Sahip",
                DataPropertyName = "SahipAdSoyad"
            });

            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "colSahipTelefon",
                HeaderText = "Sahip Telefon",
                DataPropertyName = "SahipTelefon"
            });
        }
    }
}