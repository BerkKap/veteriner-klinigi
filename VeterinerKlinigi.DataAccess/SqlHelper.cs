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