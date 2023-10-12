using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BloqueSesionPreg
    {
        public short Csondeo { get; set; }
        public short Npregunta { get; set; }
        public decimal? Npeso { get; set; }
        public decimal? Pa { get; set; }
        public decimal? Pb { get; set; }
        public decimal? Pc { get; set; }
        public decimal? Pd { get; set; }
        public decimal? Pe { get; set; }
        public decimal? Pn { get; set; }
        public decimal? Px { get; set; }
        public string Tpregunta { get; set; }
    }
}
