using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Tum
    {
        public string Cingreso { get; set; }
        public string Dpersona { get; set; }
        public string Scarrera { get; set; }
        public string Sturno { get; set; }
        public int? Cobligacion { get; set; }
        public int? Ccronograma { get; set; }
        public short Gcondicion { get; set; }
        public int Calumno { get; set; }
        public short Ccarrera { get; set; }
        public decimal? NchequeoMin { get; set; }
        public decimal? NchequeoMax { get; set; }
        public decimal? NchequeoSum { get; set; }
    }
}
