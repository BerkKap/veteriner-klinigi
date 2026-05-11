using System;
using System.IO;
using System.Windows.Forms;

namespace VeterinerKlinigi
{
    public static class Logger
    {
        public static void LogHata(Exception ex)
        {
            try
            {
                // 1. Logs klasörü oluþtur (yoksa)
                string logKlasoru = Path.Combine(Application.StartupPath, "Logs");
                if (!Directory.Exists(logKlasoru))
                {
                    Directory.CreateDirectory(logKlasoru);
                }

                // 2. Her güne ayrý dosya oluþtur (Örn: HataLog_20260511.txt)
                string dosyaAdi = $"HataLog_{DateTime.Now:yyyyMMdd}.txt";
                string tamYol = Path.Combine(logKlasoru, dosyaAdi);

                // 3. Formatlý log metni oluþtur
                string logMetni = $"[{DateTime.Now:HH:mm:ss}] HATA: {ex.Message}\n"
                                + $"DETAY: {ex.StackTrace}\n"
                                + "--------------------------------------------------\n";

                // 4. Dosyaya yaz (yoksa oluþturur, varsa altýna ekler)
                File.AppendAllText(tamYol, logMetni);
            }
            catch
            {
                // Log tutulamazsa uygulamanýn çökmesini engelleriz
            }
        }
    }
}