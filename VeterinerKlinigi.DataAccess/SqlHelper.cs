using System.Data;
using Microsoft.Data.SqlClient;

namespace VeterinerKlinigi.DataAccess
{
    public static class SqlHelper
    {
        private const string ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=VeterinerKlinigi;Integrated Security=True;TrustServerCertificate=True";

        public static SqlConnection BaglantiOlustur()
        {
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