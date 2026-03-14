using VeterinerKlinigi.DataAccess;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // TEST BUTONU
        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                // TEST: SAHÝP EKLE
                Sahip yeniSahip = new Sahip
                {
                    Ad = "Ahmet",
                    Soyad = "Yýlmaz",
                    Telefon = "05551234567",
                    Email = "ahmet@mail.com",
                    Adres = "Ankara"
                };

                int sonuc = SahipDAL.Add(yeniSahip);
                if (sonuc > 0)
                    MessageBox.Show("? Sahip baþarýyla eklendi!");
                else
                    MessageBox.Show("? Hata oluþtu!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"? Hata: {ex.Message}");
            }
        }

        // SAHÝP EKLE BUTONU
        private void btnSahipEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sahip Ekle formu açýlacak (henüz oluþturulmadý)");
        }

        // SAHÝPLERÝ LÝSTELE BUTONU
        private void btnSahipListele_Click(object sender, EventArgs e)
        {
            try
            {
                var sahipler = SahipDAL.GetAll();
                string mesaj = $"Toplam Sahip Sayýsý: {sahipler.Count}\n\n";
                
                foreach (var sahip in sahipler)
                {
                    mesaj += $"ID: {sahip.SahipId}, Ad: {sahip.Ad} {sahip.Soyad}, Tel: {sahip.Telefon}\n";
                }

                MessageBox.Show(mesaj, "Sahip Listesi");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"? Hata: {ex.Message}");
            }
        }
    }
}