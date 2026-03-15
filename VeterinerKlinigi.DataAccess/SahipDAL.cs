using Microsoft.Data.SqlClient;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi.DataAccess
{
    public class SahipDAL
    {
        public List<Sahip> TumSahipleriGetir()
        {
            const string sorgu = """
                                 SELECT SahipId, Ad, Soyad, Telefon
                                 FROM Sahipler
                                 ORDER BY SahipId
                                 """;

            var tablo = SqlHelper.ExecuteDataTable(sorgu);
            var sahipler = new List<Sahip>();

            foreach (System.Data.DataRow satir in tablo.Rows)
            {
                sahipler.Add(new Sahip
                {
                    SahipId = Convert.ToInt32(satir["SahipId"]),
                    Ad = satir["Ad"]?.ToString() ?? string.Empty,
                    Soyad = satir["Soyad"]?.ToString() ?? string.Empty,
                    Telefon = satir["Telefon"]?.ToString() ?? string.Empty
                });
            }

            return sahipler;
        }

        public int SahipEkle(Sahip sahip)
        {
            const string sorgu = """
                                 INSERT INTO Sahipler (Ad, Soyad, Telefon)
                                 OUTPUT INSERTED.SahipId
                                 VALUES (@Ad, @Soyad, @Telefon)
                                 """;

            var sonuc = SqlHelper.ExecuteScalar(
                sorgu,
                new SqlParameter("@Ad", sahip.Ad),
                new SqlParameter("@Soyad", sahip.Soyad),
                new SqlParameter("@Telefon", sahip.Telefon));

            return Convert.ToInt32(sonuc);
        }

        public bool SahipGuncelle(Sahip sahip)
        {
            const string sorgu = """
                                 UPDATE Sahipler
                                 SET Ad = @Ad,
                                     Soyad = @Soyad,
                                     Telefon = @Telefon
                                 WHERE SahipId = @SahipId
                                 """;

            var etkilenenSatir = SqlHelper.ExecuteNonQuery(
                sorgu,
                new SqlParameter("@SahipId", sahip.SahipId),
                new SqlParameter("@Ad", sahip.Ad),
                new SqlParameter("@Soyad", sahip.Soyad),
                new SqlParameter("@Telefon", sahip.Telefon));

            return etkilenenSatir > 0;
        }

        public bool SahipSil(int sahipId)
        {
            const string sorgu = "DELETE FROM Sahipler WHERE SahipId = @SahipId";

            var etkilenenSatir = SqlHelper.ExecuteNonQuery(
                sorgu,
                new SqlParameter("@SahipId", sahipId));

            return etkilenenSatir > 0;
        }
    }
}