namespace VeterinerKlinigi
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Global hata yakalayýcýyý devreye sokuyoruz (Kurulum ödevi kriteri)
            Application.ThreadException += Application_ThreadException;
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using var girisForm = new GirisForm();
            if (girisForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Form1());
            }
        }

        // Yakalanmamýþ hatalar buraya düþer
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            // 1. Hatayý arka planda dosyaya (Log'a) kaydet
            Logger.LogHata(e.Exception);

            // 2. Kullanýcýya kibar uyarý ver
            MessageBox.Show(
                "Sistemde beklenmeyen bir hata oluþtu.\n" +
                "Kayýt iþlemi veya veritabaný baðlantýsý kesilmiþ olabilir.\n" +
                "Hata detaylarý 'Logs' klasörüne kaydedildi.",
                "Sistem Uyarýsý",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}