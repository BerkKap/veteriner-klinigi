namespace VeterinerKlinigi.Entities
{
    public class Kullanici
    {
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; } = string.Empty;
        public string Sifre { get; set; } = string.Empty;
        public string TamAd { get; set; } = string.Empty;
    }
}
