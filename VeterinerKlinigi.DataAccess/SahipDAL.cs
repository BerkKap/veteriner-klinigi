using Microsoft.Data.SqlClient;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi.DataAccess
{
    public class SahipDAL
    {
        public List<Sahip> TumSahipleriGetir()
        {
            const string sorgu = """
                                 SELECT SahipId, Ad, Soyad, Telefon, CezaPuani
                                 FROM Sahipler
                                 ORDER BY SahipId
                                 """;

            var tablo = SqlHelper.ExecuteDataTable(sorgu);
            return TabloyuSahipListesineDonustur(tablo);
        }

        public List<Sahip> SahipAra(string kelime)
        {
            const string sorgu = """
                                 SELECT SahipId, Ad, Soyad, Telefon, CezaPuani
                                 FROM Sahipler
                                 WHERE Ad LIKE @kelime
                                    OR Soyad LIKE @kelime
                                    OR Telefon LIKE @kelime
                                 ORDER BY SahipId
                                 """;

            var tablo = SqlHelper.ExecuteDataTable(
                sorgu,
                new SqlParameter("@kelime", $"%{kelime}%"));

            return TabloyuSahipListesineDonustur(tablo);
        }

        public int SahipEkle(Sahip sahip)
        {
            const string sorgu = """
                                 INSERT INTO Sahipler (Ad, Soyad, Telefon, CezaPuani)
                                 OUTPUT INSERTED.SahipId
                                 VALUES (@Ad, @Soyad, @Telefon, @CezaPuani)
                                 """;

            var sonuc = SqlHelper.ExecuteScalar(
                sorgu,
                new SqlParameter("@Ad", sahip.Ad),
                new SqlParameter("@Soyad", sahip.Soyad),
                new SqlParameter("@Telefon", sahip.Telefon),
                new SqlParameter("@CezaPuani", sahip.CezaPuani));

            return Convert.ToInt32(sonuc);
        }

        public bool SahipGuncelle(Sahip sahip)
        {
            const string sorgu = """
                                 UPDATE Sahipler
                                 SET Ad = @Ad,
                                     Soyad = @Soyad,
                                     Telefon = @Telefon,
                                     CezaPuani = @CezaPuani
                                 WHERE SahipId = @SahipId
                                 """;

            var etkilenenSatir = SqlHelper.ExecuteNonQuery(
                sorgu,
                new SqlParameter("@SahipId", sahip.SahipId),
                new SqlParameter("@Ad", sahip.Ad),
                new SqlParameter("@Soyad", sahip.Soyad),
                new SqlParameter("@Telefon", sahip.Telefon),
                new SqlParameter("@CezaPuani", sahip.CezaPuani));

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

        private static List<Sahip> TabloyuSahipListesineDonustur(System.Data.DataTable tablo)
        {
            var sahipler = new List<Sahip>();

            foreach (System.Data.DataRow satir in tablo.Rows)
            {
                sahipler.Add(new Sahip
                {
                    SahipId = Convert.ToInt32(satir["SahipId"]),
                    Ad = satir["Ad"]?.ToString() ?? string.Empty,
                    Soyad = satir["Soyad"]?.ToString() ?? string.Empty,
                    Telefon = satir["Telefon"]?.ToString() ?? string.Empty,
                    CezaPuani = Convert.ToInt32(satir["CezaPuani"])
                });
            }

            return sahipler;
        }
    }
}