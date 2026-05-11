using VeterinerKlinigi.DataAccess;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi
{
    public partial class HayvanGuncelleForm : Form
    {
        private readonly HayvanDAL _hayvanDal = new();
        private readonly SahipDAL _sahipDal = new();
        private readonly int _seciliHayvanId;

        public HayvanGuncelleForm(int hayvanId)
        {
            InitializeComponent();
            _seciliHayvanId = hayvanId;
            ThemeHelper.Uygula(this);
            StartPosition = FormStartPosition.CenterParent;
        }

        private void HayvanGuncelleForm_Load(object? sender, EventArgs e)
        {
            SahipleriYukle();
            HayvanBilgileriniGetir();
        }

        private void SahipleriYukle()
        {
            var sahipler = _sahipDal.TumSahipleriGetir()
                .Select(s => new { s.SahipId, AdSoyad = $"{s.Ad} {s.Soyad}" })
                .ToList();

            cmbSahip.DataSource = sahipler;
            cmbSahip.DisplayMember = "AdSoyad";
            cmbSahip.ValueMember = "SahipId";
        }

        private void HayvanBilgileriniGetir()
        {
            var hayvan = _hayvanDal.GetById(_seciliHayvanId);
            if (hayvan != null)
            {
                txtAd.Text = hayvan.Ad;
                txtTur.Text = hayvan.Tur;
                txtCins.Text = hayvan.Cins;
                cmbCinsiyet.SelectedItem = hayvan.Cinsiyet;
                if (hayvan.Yas.HasValue) nudYas.Value = hayvan.Yas.Value;
                txtRenk.Text = hayvan.Renk;
                cmbSahip.SelectedValue = hayvan.SahipId;
            }
        }

        private void btnKaydet_Click(object? sender, EventArgs e)
        {
            var hayvan = _hayvanDal.GetById(_seciliHayvanId);
            if (hayvan == null) return;

            hayvan.Ad = txtAd.Text.Trim();
            hayvan.Tur = txtTur.Text.Trim();
            hayvan.Cins = txtCins.Text.Trim();
            hayvan.Cinsiyet = cmbCinsiyet.SelectedItem?.ToString() ?? "";
            hayvan.Yas = nudYas.Value > 0 ? Convert.ToInt32(nudYas.Value) : null;
            hayvan.Renk = txtRenk.Text.Trim();
            hayvan.SahipId = Convert.ToInt32(cmbSahip.SelectedValue);

            if (_hayvanDal.Update(hayvan))
            {
                MessageBox.Show("Hayvan güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnIptal_Click(object? sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}