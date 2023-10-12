using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaCngAsiento
    {
        public int CndAsientoControlId { get; set; }
        public string Sgrupo { get; set; }
        public int? Norden { get; set; }
        public string Cctaco { get; set; }
        public decimal? Nmonto { get; set; }
        public string Debhab { get; set; }
    }
}
