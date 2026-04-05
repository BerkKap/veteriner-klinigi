using Microsoft.Data.SqlClient;
using VeterinerKlinigi.DataAccess;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi
{
    public partial class SahipGuncelleForm : Form
    {
        private readonly SahipDAL _sahipDal = new();
        private readonly int _secilenSahipId;

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
            txtCezaPuani.Text = sahip.CezaPuani.ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad zorunludur.");
                return;
            }

            if (!int.TryParse(txtCezaPuani.Text.Trim(), out var cezaPuani))
            {
                MessageBox.Show("Ceza puaný sayýsal olmalýdýr.");
                return;
            }

            try
            {
                var guncelSahip = new Sahip
                {
                    SahipId = _secilenSahipId,
                    Ad = txtAd.Text.Trim(),
                    Soyad = txtSoyad.Text.Trim(),
                    Telefon = txtTelefon.Text.Trim(),
                    CezaPuani = cezaPuani
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
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabaný hatasý: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bilinmeyen hata: " + ex.Message);
            }
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