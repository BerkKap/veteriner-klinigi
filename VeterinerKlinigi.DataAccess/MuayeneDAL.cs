using Microsoft.Data.SqlClient;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi.DataAccess
{
    public class MuayeneDAL
    {
        public List<Muayene> GetAll()
        {
            const string query = """
                                 SELECT MuayeneId, HayvanId, Tarih, Sikayet, Tedavi, Ucret
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
                    Tarih = Convert.ToDateTime(row["Tarih"]),
                    Sikayet = row["Sikayet"]?.ToString() ?? string.Empty,
                    Tedavi = row["Tedavi"]?.ToString() ?? string.Empty,
                    Ucret = Convert.ToDecimal(row["Ucret"])
                });
            }

            return list;
        }

        public Muayene? GetById(int muayeneId)
        {
            const string query = """
                                 SELECT MuayeneId, HayvanId, Tarih, Sikayet, Tedavi, Ucret
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
                Tarih = Convert.ToDateTime(row["Tarih"]),
                Sikayet = row["Sikayet"]?.ToString() ?? string.Empty,
                Tedavi = row["Tedavi"]?.ToString() ?? string.Empty,
                Ucret = Convert.ToDecimal(row["Ucret"])
            };
        }

        public int Add(Muayene muayene)
        {
            const string query = """
                                 INSERT INTO Muayeneler (HayvanId, Tarih, Sikayet, Tedavi, Ucret)
                                 OUTPUT INSERTED.MuayeneId
                                 VALUES (@HayvanId, @Tarih, @Sikayet, @Tedavi, @Ucret)
                                 """;

            var result = SqlHelper.ExecuteScalar(
                query,
                new SqlParameter("@HayvanId", muayene.HayvanId),
                new SqlParameter("@Tarih", muayene.Tarih),
                new SqlParameter("@Sikayet", muayene.Sikayet),
                new SqlParameter("@Tedavi", muayene.Tedavi),
                new SqlParameter("@Ucret", muayene.Ucret));

            return Convert.ToInt32(result);
        }

        public bool Update(Muayene muayene)
        {
            const string query = """
                                 UPDATE Muayeneler
                                 SET HayvanId = @HayvanId,
                                     Tarih = @Tarih,
                                     Sikayet = @Sikayet,
                                     Tedavi = @Tedavi,
                                     Ucret = @Ucret
                                 WHERE MuayeneId = @MuayeneId
                                 """;

            var affectedRows = SqlHelper.ExecuteNonQuery(
                query,
                new SqlParameter("@MuayeneId", muayene.MuayeneId),
                new SqlParameter("@HayvanId", muayene.HayvanId),
                new SqlParameter("@Tarih", muayene.Tarih),
                new SqlParameter("@Sikayet", muayene.Sikayet),
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
    }
}