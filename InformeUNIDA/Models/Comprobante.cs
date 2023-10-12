using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Comprobante
    {
        public int Ccomprobante { get; set; }
        public int? Calumno { get; set; }
        public int? Cingreso { get; set; }
        public byte[] Comprobante1 { get; set; }
        public string RazonSocial { get; set; }
        public string Ruc { get; set; }
        public string BocaCobranza { get; set; }
        public string Tipo { get; set; }
        public string Tpago { get; set; }
        public string Motivo { get; set; }
        public int? Estado { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string CmodificacionProcesa { get; set; }
        public DateTime? FmodificacionProcesa { get; set; }
    }
}
