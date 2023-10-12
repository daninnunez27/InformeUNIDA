using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaComprobanteH
    {
        public short Cinstitucion { get; set; }
        public int Ccomprobante { get; set; }
        public string Stipo { get; set; }
        public string Sorigen { get; set; }
        public int Cinteraccion { get; set; }
        public int Nserie { get; set; }
        public int Nnumero { get; set; }
        public string Celaboracion { get; set; }
        public string Sestado { get; set; }
        public string Tlugar { get; set; }
        public DateTime Femision { get; set; }
        public DateTime Fpago { get; set; }
        public DateTime? Fimpresion { get; set; }
        public decimal NmontoTotal { get; set; }
        public decimal NporcentajeImpuesto { get; set; }
        public string Tsolicitante { get; set; }
        public string Tcarrera { get; set; }
        public string Cingreso { get; set; }
        public string Truc { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Tobservacion { get; set; }
        public decimal? NmontoBruto { get; set; }
        public decimal? NmontoImpuesto { get; set; }
        public decimal? NmontoExenta { get; set; }
        public int? GcondicionVenta { get; set; }
        public int? CcomprobanteRelacionado { get; set; }
    }
}
