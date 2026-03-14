using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinerKlinigi.DataAccess;
using VeterinerKlinigi.Entities;

namespace VeterinerKilinigi.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                Sahip yeniSahip = new Sahip
                {
                    Ad = "Ahmet",
                    Soyad = "Yılmaz",
                    Telefon = "05551234567",
                    Email = "ahmet@mail.com",
                    Adres = "Ankara"
                };

                int sonuc = SahipDAL.Add(yeniSahip);
                MessageBox.Show(sonuc > 0 ? "Sahip eklendi." : "Kayıt eklenemedi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }

        private void btnSahipEkle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sahip Ekle tıklandı.");
        }

        private void btnSahipListele_Click(object sender, EventArgs e)
        {
            try
            {
                var sahipler = SahipDAL.GetAll();
                MessageBox.Show($"Toplam sahip: {sahipler.Count}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
    }
}
