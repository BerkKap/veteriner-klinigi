using System.IO;
using VeterinerKlinigi.DataAccess;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi
{
    public partial class HayvanListesiForm : Form
    {
        private readonly HayvanDAL _hayvanDal = new();
        
        // 'Gerekli' yada null uyarýlarýný kapatmak için = new() atandý veya ? eklenebilir.
        private List<HayvanDetayDTO> _tumHayvanlar = new(); 

        public HayvanListesiForm()
        {
            InitializeComponent();
            ThemeHelper.Uygula(this);
            ClientSize = new Size(1250, 450);
            MinimumSize = new Size(1150, 470);

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
            if (form.ShowDialog() == DialogResult.OK)
                HayvanlariListele();
        }

        private void btnMuayeneEkle_Click(object sender, EventArgs e)
        {
            using var form = new MuayeneEkleForm();
            if (form.ShowDialog() == DialogResult.OK)
                HayvanlariListele();
        }

        // Ana Listeleme iþlemi
        private void HayvanlariListele()
        {
            _tumHayvanlar = _hayvanDal.GetAllDetayli(); 
            // Eðer textbox'ýmýz oluþturulduysa metnini alýp filtreleme baþlatýrýz
            AramayiUygula(txtArama != null ? txtArama.Text : "");
        }

        // Tasarým ekranýnda Textbox'a çift týkladýðýnýzda oluþan yer burasýdýr:
        private void txtArama_TextChanged(object sender, EventArgs e)
        {
            // TextBox objesinin null olma ihtimaline karþý null denetimi (?) ekledik
            AramayiUygula(txtArama?.Text ?? "");
        }

        private void AramayiUygula(string anahtarKelime)
        {
            if (_tumHayvanlar == null) return;

            dgvHayvanlar.DataSource = null;

            if (string.IsNullOrWhiteSpace(anahtarKelime))
            {
                dgvHayvanlar.DataSource = _tumHayvanlar;
            }
            else
            {
                var aranan = anahtarKelime.ToLower();
                var filtrelenmisListe = _tumHayvanlar.Where(h => 
                    h.HayvanAdi.ToLower().Contains(aranan) || 
                    h.Tur.ToLower().Contains(aranan) || 
                    h.SahipAdSoyad.ToLower().Contains(aranan) 
                ).ToList();

                dgvHayvanlar.DataSource = filtrelenmisListe;
            }

            if (dgvHayvanlar.Rows.Count > 0 && dgvHayvanlar.Rows[0].DataBoundItem is HayvanDetayDTO dto)
            {
                SahipResminiGoster(dto.ProfilResmi);
            }
            else
            {
                SahipResminiGoster(null);
            }
        }

        private void dgvHayvanlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvHayvanlar.CurrentRow?.DataBoundItem is HayvanDetayDTO dto)
            {
                SahipResminiGoster(dto.ProfilResmi);
            }
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
                pbSahipProfil.ImageLocation = resimYolu;
            else if (File.Exists(varsayilanYol))
                pbSahipProfil.ImageLocation = varsayilanYol;
            else
                pbSahipProfil.ImageLocation = null;
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

            if (dgvHayvanlar.Columns.Count > 0) return;

            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn { Name = "colHayvanId", HeaderText = "Id", DataPropertyName = "HayvanId", FillWeight = 50 });
            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn { Name = "colHayvanAdi", HeaderText = "Ad", DataPropertyName = "HayvanAdi", FillWeight = 110 });
            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTur", HeaderText = "Tür", DataPropertyName = "Tur", FillWeight = 90 });
            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCins", HeaderText = "Cins", DataPropertyName = "Cins", FillWeight = 110 });
            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn { Name = "colCinsiyet", HeaderText = "Cinsiyet", DataPropertyName = "Cinsiyet", FillWeight = 85 });
            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn { Name = "colYas", HeaderText = "Yaþ", DataPropertyName = "Yas", FillWeight = 60 });
            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn { Name = "colRenk", HeaderText = "Renk", DataPropertyName = "Renk", FillWeight = 90 });
            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn { Name = "colMuayeneSayisi", HeaderText = "Muayene", DataPropertyName = "MuayeneSayisi", FillWeight = 80 });
            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSahipAdSoyad", HeaderText = "Sahip", DataPropertyName = "SahipAdSoyad", FillWeight = 140 });
            dgvHayvanlar.Columns.Add(new DataGridViewTextBoxColumn { Name = "colSahipTelefon", HeaderText = "Telefon", DataPropertyName = "SahipTelefon", FillWeight = 120 });
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvHayvanlar.CurrentRow?.DataBoundItem is not HayvanDetayDTO secilenHayvan) return;

            var sonuc = MessageBox.Show($"{secilenHayvan.HayvanAdi} silinecek, emin misiniz?", "Silme Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                if (_hayvanDal.Delete(secilenHayvan.HayvanId))
                {
                    MessageBox.Show("Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HayvanlariListele();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvHayvanlar.CurrentRow?.DataBoundItem is not HayvanDetayDTO secilenHayvan) return;

            using var form = new HayvanGuncelleForm(secilenHayvan.HayvanId);
            if (form.ShowDialog() == DialogResult.OK) HayvanlariListele();
        }

        private void btnGecmis_Click(object sender, EventArgs e)
        {
            if (dgvHayvanlar.CurrentRow?.DataBoundItem is not HayvanDetayDTO secilenHayvan) return;

            using var form = new MuayeneGecmisiForm(secilenHayvan.HayvanId, secilenHayvan.HayvanAdi);
            form.ShowDialog();
        }
    }
}