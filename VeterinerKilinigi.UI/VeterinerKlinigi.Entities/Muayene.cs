using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinerKlinigi.Entities
{
    public class Muayene
    {
        public int MuayeneId { get; set; }
        public int HayvanId { get; set; }
        public DateTime MuayeneTarihi { get; set; }
        public string Sikayet { get; set; }
        public string Bulgu { get; set; }
        public string Tedavi { get; set; }
        public decimal? Ucret { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
}
