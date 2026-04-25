using Microsoft.Data.SqlClient;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi.DataAccess
{
    public class HayvanDAL
    {
        public List<Hayvan> GetAll()
        {
            const string query = """
                                 SELECT HayvanId, Ad, Tur, Cins, SahipId
                                 FROM Hayvanlar
                                 ORDER BY HayvanId
                                 """;

            var table = SqlHelper.ExecuteDataTable(query);
            var list = new List<Hayvan>();

            foreach (System.Data.DataRow row in table.Rows)
            {
                list.Add(new Hayvan
                {
                    HayvanId = Convert.ToInt32(row["HayvanId"]),
                    Ad = row["Ad"]?.ToString() ?? string.Empty,
                    Tur = row["Tur"]?.ToString() ?? string.Empty,
                    Cins = row["Cins"]?.ToString() ?? string.Empty,
                    SahipId = Convert.ToInt32(row["SahipId"])
                });
            }

            return list;
        }

        public Hayvan? GetById(int hayvanId)
        {
            const string query = """
                                 SELECT HayvanId, Ad, Tur, Cins, SahipId
                                 FROM Hayvanlar
                                 WHERE HayvanId = @HayvanId
                                 """;

            var table = SqlHelper.ExecuteDataTable(
                query,
                new SqlParameter("@HayvanId", hayvanId));

            if (table.Rows.Count == 0)
            {
                return null;
            }

            var row = table.Rows[0];
            return new Hayvan
            {
                HayvanId = Convert.ToInt32(row["HayvanId"]),
                Ad = row["Ad"]?.ToString() ?? string.Empty,
                Tur = row["Tur"]?.ToString() ?? string.Empty,
                Cins = row["Cins"]?.ToString() ?? string.Empty,
                SahipId = Convert.ToInt32(row["SahipId"])
            };
        }

        public int Add(Hayvan hayvan)
        {
            const string query = """
                                 INSERT INTO Hayvanlar (Ad, Tur, Cins, SahipId)
                                 OUTPUT INSERTED.HayvanId
                                 VALUES (@Ad, @Tur, @Cins, @SahipId)
                                 """;

            var result = SqlHelper.ExecuteScalar(
                query,
                new SqlParameter("@Ad", hayvan.Ad),
                new SqlParameter("@Tur", hayvan.Tur),
                new SqlParameter("@Cins", hayvan.Cins),
                new SqlParameter("@SahipId", hayvan.SahipId));

            return Convert.ToInt32(result);
        }

        public bool Update(Hayvan hayvan)
        {
            const string query = """
                                 UPDATE Hayvanlar
                                 SET Ad = @Ad,
                                     Tur = @Tur,
                                     Cins = @Cins,
                                     SahipId = @SahipId
                                 WHERE HayvanId = @HayvanId
                                 """;

            var affectedRows = SqlHelper.ExecuteNonQuery(
                query,
                new SqlParameter("@HayvanId", hayvan.HayvanId),
                new SqlParameter("@Ad", hayvan.Ad),
                new SqlParameter("@Tur", hayvan.Tur),
                new SqlParameter("@Cins", hayvan.Cins),
                new SqlParameter("@SahipId", hayvan.SahipId));

            return affectedRows > 0;
        }

        public bool Delete(int hayvanId)
        {
            const string query = "DELETE FROM Hayvanlar WHERE HayvanId = @HayvanId";

            var affectedRows = SqlHelper.ExecuteNonQuery(
                query,
                new SqlParameter("@HayvanId", hayvanId));

            return affectedRows > 0;
        }

        public List<HayvanDetayDTO> GetAllDetayli()
        {
            const string query = """
                         SELECT h.HayvanId,
                                h.Ad AS HayvanAdi,
                                h.Tur,
                                h.Cins,
                                s.SahipId,
                                CONCAT(s.Ad, ' ', s.Soyad) AS SahipAdSoyad,
                                s.Telefon AS SahipTelefon,
                                s.ProfilResmi
                         FROM Hayvanlar h
                         INNER JOIN Sahipler s ON s.SahipId = h.SahipId
                         ORDER BY h.HayvanId
                         """;

            var table = SqlHelper.ExecuteDataTable(query);
            var list = new List<HayvanDetayDTO>();

            foreach (System.Data.DataRow row in table.Rows)
            {
                list.Add(new HayvanDetayDTO
                {
                    HayvanId = Convert.ToInt32(row["HayvanId"]),
                    HayvanAdi = row["HayvanAdi"]?.ToString() ?? string.Empty,
                    Tur = row["Tur"]?.ToString() ?? string.Empty,
                    Cins = row["Cins"]?.ToString() ?? string.Empty,
                    SahipId = Convert.ToInt32(row["SahipId"]),
                    SahipAdSoyad = row["SahipAdSoyad"]?.ToString() ?? string.Empty,
                    SahipTelefon = row["SahipTelefon"]?.ToString() ?? string.Empty,
                    ProfilResmi = row["ProfilResmi"]?.ToString() ?? "default.png"
                });
            }

            return list;
        }
    }
}