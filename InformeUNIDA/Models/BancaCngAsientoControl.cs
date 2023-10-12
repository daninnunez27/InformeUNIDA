using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaCngAsientoControl
    {
        public int CndAsientoControlId { get; set; }
        public string Sasiento { get; set; }
        public int? NanoContable { get; set; }
        public int? NmesContable { get; set; }
        public int? NdiaContable { get; set; }
        public string AaaammddDesde { get; set; }
        public string AaaammddHasta { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Ccreacion { get; set; }
        public decimal? ValidaCuenta { get; set; }
        public decimal? ValidaCuadre { get; set; }
    }
}
