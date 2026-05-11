using Microsoft.Data.SqlClient;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi.DataAccess
{
    public class HayvanDAL
    {
        public List<Hayvan> GetAll()
        {
            const string query = """
                                 SELECT HayvanId, Ad, Tur, Cins, Cinsiyet, Yas, Renk, SahipId, KayitTarihi, MuayeneSayisi
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
                    Cinsiyet = row["Cinsiyet"]?.ToString() ?? string.Empty,
                    Yas = row["Yas"] == DBNull.Value ? null : Convert.ToInt32(row["Yas"]),
                    Renk = row["Renk"]?.ToString() ?? string.Empty,
                    SahipId = Convert.ToInt32(row["SahipId"]),
                    KayitTarihi = row["KayitTarihi"] == DBNull.Value ? null : Convert.ToDateTime(row["KayitTarihi"]),
                    MuayeneSayisi = row["MuayeneSayisi"] == DBNull.Value ? 0 : Convert.ToInt32(row["MuayeneSayisi"])
                });
            }

            return list;
        }

        public Hayvan? GetById(int hayvanId)
        {
            const string query = """
                                 SELECT HayvanId, Ad, Tur, Cins, Cinsiyet, Yas, Renk, SahipId, KayitTarihi, MuayeneSayisi
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
                Cinsiyet = row["Cinsiyet"]?.ToString() ?? string.Empty,
                Yas = row["Yas"] == DBNull.Value ? null : Convert.ToInt32(row["Yas"]),
                Renk = row["Renk"]?.ToString() ?? string.Empty,
                SahipId = Convert.ToInt32(row["SahipId"]),
                KayitTarihi = row["KayitTarihi"] == DBNull.Value ? null : Convert.ToDateTime(row["KayitTarihi"]),
                MuayeneSayisi = row["MuayeneSayisi"] == DBNull.Value ? 0 : Convert.ToInt32(row["MuayeneSayisi"])
            };
        }

        public int Add(Hayvan hayvan)
        {
            const string query = """
                                 INSERT INTO Hayvanlar (Ad, Tur, Cins, Cinsiyet, Yas, Renk, SahipId, KayitTarihi, MuayeneSayisi)
                                 OUTPUT INSERTED.HayvanId
                                 VALUES (@Ad, @Tur, @Cins, @Cinsiyet, @Yas, @Renk, @SahipId, @KayitTarihi, @MuayeneSayisi)
                                 """;

            var result = SqlHelper.ExecuteScalar(
                query,
                new SqlParameter("@Ad", hayvan.Ad),
                new SqlParameter("@Tur", hayvan.Tur),
                new SqlParameter("@Cins", hayvan.Cins),
                new SqlParameter("@Cinsiyet", hayvan.Cinsiyet ?? (object)DBNull.Value),
                new SqlParameter("@Yas", hayvan.Yas.HasValue ? hayvan.Yas.Value : (object)DBNull.Value),
                new SqlParameter("@Renk", string.IsNullOrWhiteSpace(hayvan.Renk) ? (object)DBNull.Value : hayvan.Renk),
                new SqlParameter("@SahipId", hayvan.SahipId),
                new SqlParameter("@KayitTarihi", hayvan.KayitTarihi ?? DateTime.Now),
                new SqlParameter("@MuayeneSayisi", hayvan.MuayeneSayisi));

            return Convert.ToInt32(result);
        }

        public bool Update(Hayvan hayvan)
        {
            const string query = """
                                 UPDATE Hayvanlar
                                 SET Ad = @Ad,
                                     Tur = @Tur,
                                     Cins = @Cins,
                                     Cinsiyet = @Cinsiyet,
                                     Yas = @Yas,
                                     Renk = @Renk,
                                     SahipId = @SahipId,
                                     MuayeneSayisi = @MuayeneSayisi
                                 WHERE HayvanId = @HayvanId
                                 """;

            var affectedRows = SqlHelper.ExecuteNonQuery(
                query,
                new SqlParameter("@HayvanId", hayvan.HayvanId),
                new SqlParameter("@Ad", hayvan.Ad),
                new SqlParameter("@Tur", hayvan.Tur),
                new SqlParameter("@Cins", hayvan.Cins),
                new SqlParameter("@Cinsiyet", hayvan.Cinsiyet ?? (object)DBNull.Value),
                new SqlParameter("@Yas", hayvan.Yas.HasValue ? hayvan.Yas.Value : (object)DBNull.Value),
                new SqlParameter("@Renk", string.IsNullOrWhiteSpace(hayvan.Renk) ? (object)DBNull.Value : hayvan.Renk),
                new SqlParameter("@SahipId", hayvan.SahipId),
                new SqlParameter("@MuayeneSayisi", hayvan.MuayeneSayisi));

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
                                h.Cinsiyet,
                                h.Yas,
                                h.Renk,
                                h.SahipId,
                                h.KayitTarihi,
                                h.MuayeneSayisi,
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
                    Cinsiyet = row["Cinsiyet"]?.ToString() ?? string.Empty,
                    Yas = row["Yas"] == DBNull.Value ? null : Convert.ToInt32(row["Yas"]),
                    Renk = row["Renk"]?.ToString() ?? string.Empty,
                    SahipId = Convert.ToInt32(row["SahipId"]),
                    KayitTarihi = row["KayitTarihi"] == DBNull.Value ? null : Convert.ToDateTime(row["KayitTarihi"]),
                    MuayeneSayisi = row["MuayeneSayisi"] == DBNull.Value ? 0 : Convert.ToInt32(row["MuayeneSayisi"]),
                    SahipAdSoyad = row["SahipAdSoyad"]?.ToString() ?? string.Empty,
                    SahipTelefon = row["SahipTelefon"]?.ToString() ?? string.Empty,
                    ProfilResmi = row["ProfilResmi"]?.ToString() ?? "default.png"
                });
            }

            return list;
        }
    }
}