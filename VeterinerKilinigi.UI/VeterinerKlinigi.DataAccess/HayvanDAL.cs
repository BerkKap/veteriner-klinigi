using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi.DataAccess
{
    public class HayvanDAL
    {
        public static List<Hayvan> GetAll()
        {
            List<Hayvan> hayvanlar = new List<Hayvan>();
            DataTable dt = SqlHelper.ExecuteDataTable("SELECT * FROM Hayvanlar");
            
            foreach (DataRow row in dt.Rows)
            {
                hayvanlar.Add(new Hayvan
                {
                    HayvanId = (int)row["HayvanId"],
                    Ad = row["Ad"].ToString(),
                    Tur = row["Tur"].ToString(),
                    Cins = row["Cins"] != DBNull.Value ? row["Cins"].ToString() : "",
                    Yaş = row["Yaş"] != DBNull.Value ? (int)row["Yaş"] : null,
                    Renk = row["Renk"] != DBNull.Value ? row["Renk"].ToString() : "",
                    SahipId = (int)row["SahipId"],
                    KayitTarihi = (DateTime)row["KayitTarihi"]
                });
            }
            return hayvanlar;
        }

        public static Hayvan GetById(int hayvanId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@HayvanId", hayvanId)
            };
            DataTable dt = SqlHelper.ExecuteDataTable("SELECT * FROM Hayvanlar WHERE HayvanId = @HayvanId", parameters);
            
            if (dt.Rows.Count == 0) return null;
            
            DataRow row = dt.Rows[0];
            return new Hayvan
            {
                HayvanId = (int)row["HayvanId"],
                Ad = row["Ad"].ToString(),
                Tur = row["Tur"].ToString(),
                Cins = row["Cins"] != DBNull.Value ? row["Cins"].ToString() : "",
                Yaş = row["Yaş"] != DBNull.Value ? (int)row["Yaş"] : null,
                Renk = row["Renk"] != DBNull.Value ? row["Renk"].ToString() : "",
                SahipId = (int)row["SahipId"],
                KayitTarihi = (DateTime)row["KayitTarihi"]
            };
        }

        public static int Add(Hayvan hayvan)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Ad", hayvan.Ad),
                new SqlParameter("@Tur", hayvan.Tur),
                new SqlParameter("@Cins", hayvan.Cins ?? ""),
                new SqlParameter("@Yaş", hayvan.Yaş ?? 0),
                new SqlParameter("@Renk", hayvan.Renk ?? ""),
                new SqlParameter("@SahipId", hayvan.SahipId)
            };
            return SqlHelper.ExecuteNonQuery(
                "INSERT INTO Hayvanlar (Ad, Tur, Cins, Yaş, Renk, SahipId) VALUES (@Ad, @Tur, @Cins, @Yaş, @Renk, @SahipId)",
                parameters);
        }

        public static int Update(Hayvan hayvan)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@HayvanId", hayvan.HayvanId),
                new SqlParameter("@Ad", hayvan.Ad),
                new SqlParameter("@Tur", hayvan.Tur),
                new SqlParameter("@Cins", hayvan.Cins ?? ""),
                new SqlParameter("@Yaş", hayvan.Yaş ?? 0),
                new SqlParameter("@Renk", hayvan.Renk ?? ""),
                new SqlParameter("@SahipId", hayvan.SahipId)
            };
            return SqlHelper.ExecuteNonQuery(
                "UPDATE Hayvanlar SET Ad = @Ad, Tur = @Tur, Cins = @Cins, Yaş = @Yaş, Renk = @Renk, SahipId = @SahipId WHERE HayvanId = @HayvanId",
                parameters);
        }

        public static int Delete(int hayvanId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@HayvanId", hayvanId)
            };
            return SqlHelper.ExecuteNonQuery("DELETE FROM Hayvanlar WHERE HayvanId = @HayvanId", parameters);
        }
    }
}
