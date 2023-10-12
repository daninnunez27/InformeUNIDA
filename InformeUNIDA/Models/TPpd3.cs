using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TPpd3
    {
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public string Cingreso { get; set; }
        public string Dpersona { get; set; }
        public string Scarrera { get; set; }
        public int? Spf1 { get; set; }
        public int? Spf2 { get; set; }
        public int? Spe { get; set; }
        public int? SmateriaNormal { get; set; }
        public decimal? NpuntajePeriodo { get; set; }
    }
}
