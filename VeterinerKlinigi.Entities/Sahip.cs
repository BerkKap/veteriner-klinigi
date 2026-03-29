namespace VeterinerKlinigi.Entities
{
    public class Sahip
    {
        public int SahipId { get; set; }
        public string Ad { get; set; } = string.Empty;
        public string Soyad { get; set; } = string.Empty;
        public string Telefon { get; set; } = string.Empty;
        public int CezaPuani { get; set; }
    }
}