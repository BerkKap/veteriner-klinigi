namespace VeterinerKlinigi.Entities
{
    public class Hayvan
    {
        public int HayvanId { get; set; }
        public string Ad { get; set; } = string.Empty;
        public string Tur { get; set; } = string.Empty;
        public string Cins { get; set; } = string.Empty;
        public int? Yas { get; set; }
        public string Renk { get; set; } = string.Empty;
        public int SahipId { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public int MuayeneSayisi { get; set; }
    }
}