using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi.DataAccess
{
    public class SahipDAL
    {
        public static List<Sahip> GetAll()
        {
            List<Sahip> sahipler = new List<Sahip>();
            DataTable dt = SqlHelper.ExecuteDataTable("SELECT * FROM Sahipler");
            
            foreach (DataRow row in dt.Rows)
            {
                sahipler.Add(new Sahip
                {
                    SahipId = (int)row["SahipId"],
                    Ad = row["Ad"].ToString(),
                    Soyad = row["Soyad"].ToString(),
                    Telefon = row["Telefon"].ToString(),
                    Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : "",
                    Adres = row["Adres"] != DBNull.Value ? row["Adres"].ToString() : "",
                    KayitTarihi = (DateTime)row["KayitTarihi"]
                });
            }
            return sahipler;
        }

        public static Sahip GetById(int sahipId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SahipId", sahipId)
            };
            DataTable dt = SqlHelper.ExecuteDataTable("SELECT * FROM Sahipler WHERE SahipId = @SahipId", parameters);
            
            if (dt.Rows.Count == 0) return null;
            
            DataRow row = dt.Rows[0];
            return new Sahip
            {
                SahipId = (int)row["SahipId"],
                Ad = row["Ad"].ToString(),
                Soyad = row["Soyad"].ToString(),
                Telefon = row["Telefon"].ToString(),
                Email = row["Email"] != DBNull.Value ? row["Email"].ToString() : "",
                Adres = row["Adres"] != DBNull.Value ? row["Adres"].ToString() : "",
                KayitTarihi = (DateTime)row["KayitTarihi"]
            };
        }

        public static int Add(Sahip sahip)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Ad", sahip.Ad),
                new SqlParameter("@Soyad", sahip.Soyad),
                new SqlParameter("@Telefon", sahip.Telefon),
                new SqlParameter("@Email", sahip.Email ?? ""),
                new SqlParameter("@Adres", sahip.Adres ?? "")
            };
            return SqlHelper.ExecuteNonQuery(
                "INSERT INTO Sahipler (Ad, Soyad, Telefon, Email, Adres) VALUES (@Ad, @Soyad, @Telefon, @Email, @Adres)",
                parameters);
        }

        public static int Update(Sahip sahip)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SahipId", sahip.SahipId),
                new SqlParameter("@Ad", sahip.Ad),
                new SqlParameter("@Soyad", sahip.Soyad),
                new SqlParameter("@Telefon", sahip.Telefon),
                new SqlParameter("@Email", sahip.Email ?? ""),
                new SqlParameter("@Adres", sahip.Adres ?? "")
            };
            return SqlHelper.ExecuteNonQuery(
                "UPDATE Sahipler SET Ad = @Ad, Soyad = @Soyad, Telefon = @Telefon, Email = @Email, Adres = @Adres WHERE SahipId = @SahipId",
                parameters);
        }

        public static int Delete(int sahipId)
        {
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@SahipId", sahipId)
            };
            return SqlHelper.ExecuteNonQuery("DELETE FROM Sahipler WHERE SahipId = @SahipId", parameters);
        }
    }
}
