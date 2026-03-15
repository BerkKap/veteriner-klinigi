namespace VeterinerKlinigi.Entities
{
    public class Muayene
    {
        public int MuayeneId { get; set; }
        public int HayvanId { get; set; }
        public DateTime Tarih { get; set; }
        public string Sikayet { get; set; } = string.Empty;
        public string Tedavi { get; set; } = string.Empty;
        public decimal Ucret { get; set; }
    }
}