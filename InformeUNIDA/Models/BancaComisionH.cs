using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaComisionH
    {
        public int? Ccomprobante { get; set; }
        public decimal? NmontoComision { get; set; }
        public string Observacion { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Clog { get; set; }
    }
}
