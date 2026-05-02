using Microsoft.Data.SqlClient;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi.DataAccess
{
    public class MuayeneDAL
    {
        public List<Muayene> GetAll()
        {
            const string query = """
                                 SELECT MuayeneId, HayvanId, MuayeneTarihi, Sikayet, Bulgu, Tedavi, Ucret, KayitTarihi
                                 FROM Muayeneler
                                 ORDER BY MuayeneId
                                 """;

            var table = SqlHelper.ExecuteDataTable(query);
            var list = new List<Muayene>();

            foreach (System.Data.DataRow row in table.Rows)
            {
                list.Add(new Muayene
                {
                    MuayeneId = Convert.ToInt32(row["MuayeneId"]),
                    HayvanId = Convert.ToInt32(row["HayvanId"]),
                    MuayeneTarihi = Convert.ToDateTime(row["MuayeneTarihi"]),
                    Sikayet = row["Sikayet"]?.ToString() ?? string.Empty,
                    Bulgu = row["Bulgu"]?.ToString() ?? string.Empty,
                    Tedavi = row["Tedavi"]?.ToString() ?? string.Empty,
                    Ucret = Convert.ToDecimal(row["Ucret"]),
                    KayitTarihi = row["KayitTarihi"] == DBNull.Value ? null : Convert.ToDateTime(row["KayitTarihi"])
                });
            }

            return list;
        }

        public Muayene? GetById(int muayeneId)
        {
            const string query = """
                                 SELECT MuayeneId, HayvanId, MuayeneTarihi, Sikayet, Bulgu, Tedavi, Ucret, KayitTarihi
                                 FROM Muayeneler
                                 WHERE MuayeneId = @MuayeneId
                                 """;

            var table = SqlHelper.ExecuteDataTable(
                query,
                new SqlParameter("@MuayeneId", muayeneId));

            if (table.Rows.Count == 0)
            {
                return null;
            }

            var row = table.Rows[0];
            return new Muayene
            {
                MuayeneId = Convert.ToInt32(row["MuayeneId"]),
                HayvanId = Convert.ToInt32(row["HayvanId"]),
                MuayeneTarihi = Convert.ToDateTime(row["MuayeneTarihi"]),
                Sikayet = row["Sikayet"]?.ToString() ?? string.Empty,
                Bulgu = row["Bulgu"]?.ToString() ?? string.Empty,
                Tedavi = row["Tedavi"]?.ToString() ?? string.Empty,
                Ucret = Convert.ToDecimal(row["Ucret"]),
                KayitTarihi = row["KayitTarihi"] == DBNull.Value ? null : Convert.ToDateTime(row["KayitTarihi"])
            };
        }

        public int Add(Muayene muayene)
        {
            const string query = """
                                 INSERT INTO Muayeneler (HayvanId, MuayeneTarihi, Sikayet, Bulgu, Tedavi, Ucret, KayitTarihi)
                                 OUTPUT INSERTED.MuayeneId
                                 VALUES (@HayvanId, @MuayeneTarihi, @Sikayet, @Bulgu, @Tedavi, @Ucret, @KayitTarihi)
                                 """;

            var result = SqlHelper.ExecuteScalar(
                query,
                new SqlParameter("@HayvanId", muayene.HayvanId),
                new SqlParameter("@MuayeneTarihi", muayene.MuayeneTarihi),
                new SqlParameter("@Sikayet", muayene.Sikayet),
                new SqlParameter("@Bulgu", string.IsNullOrWhiteSpace(muayene.Bulgu) ? (object)DBNull.Value : muayene.Bulgu),
                new SqlParameter("@Tedavi", muayene.Tedavi),
                new SqlParameter("@Ucret", muayene.Ucret),
                new SqlParameter("@KayitTarihi", muayene.KayitTarihi ?? DateTime.Now));

            return Convert.ToInt32(result);
        }

        public bool Update(Muayene muayene)
        {
            const string query = """
                                 UPDATE Muayeneler
                                 SET HayvanId = @HayvanId,
                                     MuayeneTarihi = @MuayeneTarihi,
                                     Sikayet = @Sikayet,
                                     Bulgu = @Bulgu,
                                     Tedavi = @Tedavi,
                                     Ucret = @Ucret
                                 WHERE MuayeneId = @MuayeneId
                                 """;

            var affectedRows = SqlHelper.ExecuteNonQuery(
                query,
                new SqlParameter("@MuayeneId", muayene.MuayeneId),
                new SqlParameter("@HayvanId", muayene.HayvanId),
                new SqlParameter("@MuayeneTarihi", muayene.MuayeneTarihi),
                new SqlParameter("@Sikayet", muayene.Sikayet),
                new SqlParameter("@Bulgu", string.IsNullOrWhiteSpace(muayene.Bulgu) ? (object)DBNull.Value : muayene.Bulgu),
                new SqlParameter("@Tedavi", muayene.Tedavi),
                new SqlParameter("@Ucret", muayene.Ucret));

            return affectedRows > 0;
        }

        public bool Delete(int muayeneId)
        {
            const string query = "DELETE FROM Muayeneler WHERE MuayeneId = @MuayeneId";

            var affectedRows = SqlHelper.ExecuteNonQuery(
                query,
                new SqlParameter("@MuayeneId", muayeneId));

            return affectedRows > 0;
        }

        public bool EkleTransaction(Muayene muayene)
        {
            using var baglanti = SqlHelper.BaglantiOlustur();
            baglanti.Open();

            using var transaction = baglanti.BeginTransaction();
            try
            {
                const string insertQuery = """
                                           INSERT INTO Muayeneler (HayvanId, MuayeneTarihi, Sikayet, Bulgu, Tedavi, Ucret, KayitTarihi)
                                           VALUES (@HayvanId, @MuayeneTarihi, @Sikayet, @Bulgu, @Tedavi, @Ucret, @KayitTarihi)
                                           """;

                using (var komut1 = new SqlCommand(insertQuery, baglanti, transaction))
                {
                    komut1.Parameters.AddWithValue("@HayvanId", muayene.HayvanId);
                    komut1.Parameters.AddWithValue("@MuayeneTarihi", muayene.MuayeneTarihi);
                    komut1.Parameters.AddWithValue("@Sikayet", muayene.Sikayet);
                    komut1.Parameters.AddWithValue("@Bulgu", string.IsNullOrWhiteSpace(muayene.Bulgu) ? (object)DBNull.Value : muayene.Bulgu);
                    komut1.Parameters.AddWithValue("@Tedavi", muayene.Tedavi);
                    komut1.Parameters.AddWithValue("@Ucret", muayene.Ucret);
                    komut1.Parameters.AddWithValue("@KayitTarihi", muayene.KayitTarihi ?? DateTime.Now);
                    komut1.ExecuteNonQuery();
                }

                const string updateQuery = """
                                           UPDATE Hayvanlar
                                           SET MuayeneSayisi = ISNULL(MuayeneSayisi, 0) + 1
                                           WHERE HayvanId = @HayvanId
                                           """;

                using (var komut2 = new SqlCommand(updateQuery, baglanti, transaction))
                {
                    komut2.Parameters.AddWithValue("@HayvanId", muayene.HayvanId);
                    komut2.ExecuteNonQuery();
                }

                transaction.Commit();
                return true;
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Muayene ekleme baþarýsýz. Ýþlemler geri alýndý.", ex);
            }
        }
    }
}