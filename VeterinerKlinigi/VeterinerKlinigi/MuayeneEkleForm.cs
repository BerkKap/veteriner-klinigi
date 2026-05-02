using VeterinerKlinigi.DataAccess;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi
{
    public partial class MuayeneEkleForm : Form
    {
        private readonly MuayeneDAL _muayeneDal = new();
        private readonly HayvanDAL _hayvanDal = new();

        public MuayeneEkleForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ThemeHelper.Uygula(this);
        }

        private void MuayeneEkleForm_Load(object sender, EventArgs e)
        {
            var hayvanlar = _hayvanDal.GetAllDetayli()
                .Select(h => new HayvanSecimItem
                {
                    HayvanId = h.HayvanId,
                    HayvanBilgi = $"{h.HayvanAdi} - {h.SahipAdSoyad}"
                })
                .ToList();

            cmbHayvan.DataSource = hayvanlar;
            cmbHayvan.DisplayMember = "HayvanBilgi";
            cmbHayvan.ValueMember = "HayvanId";
            cmbHayvan.SelectedIndex = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbHayvan.SelectedValue is null)
            {
                MessageBox.Show("Hayvan seçimi zorunludur.", "Uyarý",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var muayene = new Muayene
            {
                HayvanId = Convert.ToInt32(cmbHayvan.SelectedValue),
                MuayeneTarihi = DateTime.Now,
                Sikayet = txtSikayet.Text.Trim(),
                Bulgu = txtBulgu.Text.Trim(),
                Tedavi = txtTedavi.Text.Trim(),
                Ucret = nudUcret.Value,
                KayitTarihi = DateTime.Now
            };

            try
            {
                if (_muayeneDal.EkleTransaction(muayene))
                {
                    MessageBox.Show("Muayene kaydý eklendi.", "Bilgi",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private sealed class HayvanSecimItem
        {
            public int HayvanId { get; set; }
            public string HayvanBilgi { get; set; } = string.Empty;
        }
    }
}