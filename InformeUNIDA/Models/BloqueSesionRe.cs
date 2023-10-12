using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BloqueSesionRe
    {
        public short Csondeo { get; set; }
        public int Cencuesta { get; set; }
        public short Npregunta { get; set; }
        public string CaK { get; set; }
        public string CbK { get; set; }
        public string CcK { get; set; }
        public string CdK { get; set; }
        public string CeK { get; set; }
        public string CnK { get; set; }
        public string CxK { get; set; }
        public decimal CaP { get; set; }
        public decimal CbP { get; set; }
        public decimal CcP { get; set; }
        public decimal CdP { get; set; }
        public decimal CeP { get; set; }
        public decimal CnP { get; set; }
        public decimal CxP { get; set; }
        public decimal? Npromedio { get; set; }
        public decimal? Nponderado { get; set; }
    }
}
