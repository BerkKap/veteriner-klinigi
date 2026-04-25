using VeterinerKlinigi.DataAccess;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi
{
    public partial class HayvanEkleForm : Form
    {
        private readonly HayvanDAL _hayvanDal = new();
        private readonly SahipDAL _sahipDal = new();

        public HayvanEkleForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ThemeHelper.Uygula(this);
        }

        private void HayvanEkleForm_Load(object sender, EventArgs e)
        {
            SahipleriYukle();
        }

        private void SahipleriYukle()
        {
            var sahipler = _sahipDal.TumSahipleriGetir()
                .Select(s => new SahipSecimItem
                {
                    SahipId = s.SahipId,
                    AdSoyad = $"{s.Ad} {s.Soyad}".Trim()
                })
                .ToList();

            cmbSahip.DataSource = sahipler;
            cmbSahip.DisplayMember = "AdSoyad";
            cmbSahip.ValueMember = "SahipId";
            cmbSahip.SelectedIndex = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtTur.Text) ||
                string.IsNullOrWhiteSpace(txtCins.Text) ||
                cmbSahip.SelectedValue is null)
            {
                MessageBox.Show("Ad, Tür, Cins ve Sahip alanlarý zorunludur.", "Uyarý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var hayvan = new Hayvan
                {
                    Ad = txtAd.Text.Trim(),
                    Tur = txtTur.Text.Trim(),
                    Cins = txtCins.Text.Trim(),
                    SahipId = Convert.ToInt32(cmbSahip.SelectedValue)
                };

                var yeniId = _hayvanDal.Add(hayvan);

                if (yeniId > 0)
                {
                    MessageBox.Show("Hayvan kaydý eklendi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Kayýt eklenemedi.", "Uyarý",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private sealed class SahipSecimItem
        {
            public int SahipId { get; set; }
            public string AdSoyad { get; set; } = string.Empty;
        }
    }
}