using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi.DataAccess
{
    public class MuayeneDAL
    {
        public static List<Muayene> GetAll()
        {
            List<Muayene> muayeneler = new List<Muayene>();
            DataTable dt = SqlHelper.ExecuteDataTable("SELECT * FROM Muayeneler");
            
            foreach (DataRow row in dt.Rows)
            {
                muayeneler.Add(new Muayene
                {
                    MuayeneId = (int)row["MuayeneId"],
                    HayvanId = (int)row["HayvanId"],
                    MuayeneTarihi = (DateTime)row["MuayeneTarihi"],
                    Sikayet = row["Sikayet"] != DBNull.Value ? row["Sikayet"].ToString() : "",
                    Bulgu = row["Bulgu"] != DBNull.Value ? row["Bulgu"].ToString() : "",
                    Tedavi = row["Tedavi"] != DBNull.Value ? row["Tedavi"].ToString() : "",
                    Ucret = row["Ucret"] != DBNull.Value ? (decimal)row["Ucret"] : null,
                    KayitTarihi = (DateTime)row["KayitTarihi"]
                });
            }
            return muayeneler;
        }

        public static Muayene GetById(int muayeneId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MuayeneId", muayeneId)
            };
            DataTable dt = SqlHelper.ExecuteDataTable("SELECT * FROM Muayeneler WHERE MuayeneId = @MuayeneId", parameters);
            
            if (dt.Rows.Count == 0) return null;
            
            DataRow row = dt.Rows[0];
            return new Muayene
            {
                MuayeneId = (int)row["MuayeneId"],
                HayvanId = (int)row["HayvanId"],
                MuayeneTarihi = (DateTime)row["MuayeneTarihi"],
                Sikayet = row["Sikayet"] != DBNull.Value ? row["Sikayet"].ToString() : "",
                Bulgu = row["Bulgu"] != DBNull.Value ? row["Bulgu"].ToString() : "",
                Tedavi = row["Tedavi"] != DBNull.Value ? row["Tedavi"].ToString() : "",
                Ucret = row["Ucret"] != DBNull.Value ? (decimal)row["Ucret"] : null,
                KayitTarihi = (DateTime)row["KayitTarihi"]
            };
        }

        public static int Add(Muayene muayene)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@HayvanId", muayene.HayvanId),
                new SqlParameter("@MuayeneTarihi", muayene.MuayeneTarihi),
                new SqlParameter("@Sikayet", muayene.Sikayet ?? ""),
                new SqlParameter("@Bulgu", muayene.Bulgu ?? ""),
                new SqlParameter("@Tedavi", muayene.Tedavi ?? ""),
                new SqlParameter("@Ucret", muayene.Ucret ?? 0)
            };
            return SqlHelper.ExecuteNonQuery(
                "INSERT INTO Muayeneler (HayvanId, MuayeneTarihi, Sikayet, Bulgu, Tedavi, Ucret) VALUES (@HayvanId, @MuayeneTarihi, @Sikayet, @Bulgu, @Tedavi, @Ucret)",
                parameters);
        }

        public static int Update(Muayene muayene)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MuayeneId", muayene.MuayeneId),
                new SqlParameter("@HayvanId", muayene.HayvanId),
                new SqlParameter("@MuayeneTarihi", muayene.MuayeneTarihi),
                new SqlParameter("@Sikayet", muayene.Sikayet ?? ""),
                new SqlParameter("@Bulgu", muayene.Bulgu ?? ""),
                new SqlParameter("@Tedavi", muayene.Tedavi ?? ""),
                new SqlParameter("@Ucret", muayene.Ucret ?? 0)
            };
            return SqlHelper.ExecuteNonQuery(
                "UPDATE Muayeneler SET HayvanId = @HayvanId, MuayeneTarihi = @MuayeneTarihi, Sikayet = @Sikayet, Bulgu = @Bulgu, Tedavi = @Tedavi, Ucret = @Ucret WHERE MuayeneId = @MuayeneId",
                parameters);
        }

        public static int Delete(int muayeneId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@MuayeneId", muayeneId)
            };
            return SqlHelper.ExecuteNonQuery("DELETE FROM Muayeneler WHERE MuayeneId = @MuayeneId", parameters);
        }
    }
}
