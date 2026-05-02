namespace VeterinerKlinigi.Entities
{
    public class HayvanDetayDTO
    {
        public int HayvanId { get; set; }
        public string HayvanAdi { get; set; } = string.Empty;
        public string Tur { get; set; } = string.Empty;
        public string Cins { get; set; } = string.Empty;
        public int? Yas { get; set; }
        public string Renk { get; set; } = string.Empty;
        public int SahipId { get; set; }
        public string SahipAdSoyad { get; set; } = string.Empty;
        public string SahipTelefon { get; set; } = string.Empty;
        public string ProfilResmi { get; set; } = "default.png";
        public DateTime? KayitTarihi { get; set; }
        public int MuayeneSayisi { get; set; }
    }
}