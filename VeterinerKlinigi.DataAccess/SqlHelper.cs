using System.Data;
using Microsoft.Data.SqlClient;
using System.IO;

namespace VeterinerKlinigi.DataAccess
{
    public static class SqlHelper
    {
        // Hocanýzýn istediði Dinamik (LocalDB) baðlantý dizesi:
        private const string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\VeterinerKlinigi.mdf;Integrated Security=True;MultipleActiveResultSets=True";

        public static SqlConnection BaglantiOlustur()
        {
            // DataDirectory yolunu dinamik olarak projenin çalýþtýðý klasör olarak ayarlýyoruz
            string yol = AppDomain.CurrentDomain.BaseDirectory;
            AppDomain.CurrentDomain.SetData("DataDirectory", yol);

            // Beklenen .mdf dosyasýnýn tam yolu
            string dbPath = Path.Combine(yol, "VeterinerKlinigi.mdf");

            if (!File.Exists(dbPath))
            {
                // Daha açýklayýcý hata veriyoruz; çaðýran kod bunu loglayýp kullanýcýya bildirebilir
                throw new FileNotFoundException(
                    $"Veritabaný dosyasý bulunamadý: {dbPath}.\n" +
                    "Çözüm önerileri:\n" +
                    "1) Projedeki 'VeterinerKlinigi.mdf' dosyasýný Solution Explorer'da seçip 'Copy to Output Directory' özelliðini 'Copy if newer' olarak ayarlayýn.\n" +
                    "2) Veya .mdf dosyasýný manuel olarak uygulama çalýþtýrma dizinine (bin\\Debug veya bin\\Release) kopyalayýn.\n" +
                    "3) LocalDB'in yüklü ve çalýþýr durumda olduðundan emin olun (ör: `sqllocaldb info`).");
            }

            return new SqlConnection(ConnectionString);
        }

        public static int ExecuteNonQuery(string sorgu, params SqlParameter[] parametreler)
        {
            using var baglanti = BaglantiOlustur();
            using var komut = new SqlCommand(sorgu, baglanti);

            if (parametreler is { Length: > 0 })
            {
                komut.Parameters.AddRange(parametreler);
            }

            baglanti.Open();
            return komut.ExecuteNonQuery();
        }

        public static object? ExecuteScalar(string sorgu, params SqlParameter[] parametreler)
        {
            using var baglanti = BaglantiOlustur();
            using var komut = new SqlCommand(sorgu, baglanti);

            if (parametreler is { Length: > 0 })
            {
                komut.Parameters.AddRange(parametreler);
            }

            baglanti.Open();
            return komut.ExecuteScalar();
        }

        public static DataTable ExecuteDataTable(string sorgu, params SqlParameter[] parametreler)
        {
            using var baglanti = BaglantiOlustur();
            using var komut = new SqlCommand(sorgu, baglanti);

            if (parametreler is { Length: > 0 })
            {
                komut.Parameters.AddRange(parametreler);
            }

            using var adaptor = new SqlDataAdapter(komut);
            var tablo = new DataTable();
            adaptor.Fill(tablo);
            return tablo;
        }
    }
}