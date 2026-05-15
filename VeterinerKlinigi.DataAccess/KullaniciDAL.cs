using System;
using Microsoft.Data.SqlClient;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi.DataAccess
{
    public class KullaniciDAL
    {
        /// <summary>
        /// Kullanıcı adı ve şifreyi veritabanında kontrol eder.
        /// Doğruysa Kullanici nesnesini, yanlışsa null döner.
        /// </summary>
        public Kullanici? GirisYap(string kullaniciAdi, string sifre)
        {
            const string sorgu = """
                                 SELECT KullaniciId, KullaniciAdi, Sifre, TamAd
                                 FROM Kullanicilar
                                 WHERE KullaniciAdi = @KullaniciAdi
                                   AND Sifre        = @Sifre
                                 """;

            var tablo = SqlHelper.ExecuteDataTable(
                sorgu,
                new SqlParameter("@KullaniciAdi", kullaniciAdi),
                new SqlParameter("@Sifre", sifre));

            if (tablo.Rows.Count == 0)
                return null;

            var satir = tablo.Rows[0];
            return new Kullanici
            {
                KullaniciId  = Convert.ToInt32(satir["KullaniciId"]),
                KullaniciAdi = satir["KullaniciAdi"].ToString() ?? string.Empty,
                Sifre        = satir["Sifre"].ToString() ?? string.Empty,
                TamAd        = satir["TamAd"]?.ToString() ?? string.Empty
            };
        }
    }
}
