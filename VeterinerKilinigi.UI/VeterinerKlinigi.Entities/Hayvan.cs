using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinerKlinigi.Entities
{
    public class Hayvan
    {
        public int HayvanId { get; set; }
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string Cins { get; set; }
        public int? Yaş { get; set; }
        public string Renk { get; set; }
        public int SahipId { get; set; }
        public DateTime KayitTarihi { get; set; }
    }
}
