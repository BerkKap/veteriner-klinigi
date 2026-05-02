namespace VeterinerKlinigi.Entities
{
    public class Muayene
    {
        public int MuayeneId { get; set; }
        public int HayvanId { get; set; }
        public DateTime MuayeneTarihi { get; set; }
        public string Sikayet { get; set; } = string.Empty;
        public string Bulgu { get; set; } = string.Empty;
        public string Tedavi { get; set; } = string.Empty;
        public decimal Ucret { get; set; }
        public DateTime? KayitTarihi { get; set; }
    }
}