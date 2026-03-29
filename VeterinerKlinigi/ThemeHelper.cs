using System.Drawing;
using System.Windows.Forms;

namespace VeterinerKlinigi
{
    public static class ThemeHelper
    {
        private static readonly Color YesilAna = ColorTranslator.FromHtml("#0f6e56");
        private static readonly Color YesilKoyu = ColorTranslator.FromHtml("#085041");
        private static readonly Color Amber = ColorTranslator.FromHtml("#854F0B");
        private static readonly Color Kirmizi = ColorTranslator.FromHtml("#A32D2D");
        private static readonly Color GridBaslikArka = ColorTranslator.FromHtml("#E1F5EE");
        private static readonly Color GridBaslikYazi = ColorTranslator.FromHtml("#085041");

        public static void Uygula(Form form, bool sidebarEkle = false)
        {
            form.BackColor = Color.White;
            form.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            foreach (Control kontrol in form.Controls)
            {
                KontrolStilUygula(kontrol);
            }

            if (sidebarEkle)
            {
                SidebarEkle(form);
            }
        }

        private static void KontrolStilUygula(Control kontrol)
        {
            switch (kontrol)
            {
                case Button buton:
                    ButonStilUygula(buton);
                    break;

                case TextBox textBox:
                    textBox.BorderStyle = BorderStyle.FixedSingle;
                    textBox.BackColor = Color.White;
                    break;

                case DataGridView grid:
                    GridStilUygula(grid);
                    break;
            }

            foreach (Control alt in kontrol.Controls)
            {
                KontrolStilUygula(alt);
            }
        }

        private static void ButonStilUygula(Button buton)
        {
            var metin = $"{buton.Name} {buton.Text}".ToLowerInvariant();
            var arka = YesilAna;

            if (metin.Contains("güncelle") || metin.Contains("guncelle"))
            {
                arka = Amber;
            }
            else if (metin.Contains("sil"))
            {
                arka = Kirmizi;
            }
            else if (metin.Contains("ekle") || metin.Contains("kaydet") || metin.Contains("giriþ") || metin.Contains("giris"))
            {
                arka = YesilAna;
            }

            buton.FlatStyle = FlatStyle.Flat;
            buton.FlatAppearance.BorderSize = 0;
            buton.BackColor = arka;
            buton.ForeColor = Color.White;
        }

        private static void GridStilUygula(DataGridView grid)
        {
            grid.BackgroundColor = Color.White;
            grid.BorderStyle = BorderStyle.FixedSingle;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = GridBaslikArka;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = GridBaslikYazi;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = GridBaslikArka;
            grid.ColumnHeadersDefaultCellStyle.SelectionForeColor = GridBaslikYazi;

            grid.DefaultCellStyle.SelectionBackColor = GridBaslikArka;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private static void SidebarEkle(Form form)
        {
            if (form.Controls.ContainsKey("pnlSidebar"))
            {
                return;
            }

            var panel = new Panel
            {
                Name = "pnlSidebar",
                Width = 52,
                Dock = DockStyle.Left,
                BackColor = YesilKoyu
            };

            var ikon1 = new Label { Text = "??", ForeColor = Color.White, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Width = 52, Height = 40, Top = 20, Font = new Font("Segoe UI Emoji", 16F) };
            var ikon2 = new Label { Text = "??", ForeColor = Color.White, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Width = 52, Height = 40, Top = 70, Font = new Font("Segoe UI Emoji", 16F) };
            var ikon3 = new Label { Text = "??", ForeColor = Color.White, AutoSize = false, TextAlign = ContentAlignment.MiddleCenter, Width = 52, Height = 40, Top = 120, Font = new Font("Segoe UI Emoji", 16F) };

            panel.Controls.Add(ikon1);
            panel.Controls.Add(ikon2);
            panel.Controls.Add(ikon3);

            var tasinacakKontroller = form.Controls.Cast<Control>().ToList();
            foreach (var kontrol in tasinacakKontroller)
            {
                if (kontrol.Dock == DockStyle.None)
                {
                    kontrol.Left += 52;
                }
            }

            form.Controls.Add(panel);
            panel.BringToFront();
        }
    }
}