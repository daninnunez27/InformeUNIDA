using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class VBancaComprobantePorInteraccion
    {
        public short Csede { get; set; }
        public int GcondicionVenta { get; set; }
        public int Nserie { get; set; }
        public int Nnumero { get; set; }
        public string Tlugar { get; set; }
        public DateTime Fpago { get; set; }
        public DateTime? Fimpresion { get; set; }
        public string Tsolicitante { get; set; }
        public string Tcarrera { get; set; }
        public string Cingreso { get; set; }
        public string Truc { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public DateTime? Fvencimiento { get; set; }
        public int? CcomprobanteRelacionado { get; set; }
        public int Ccomprobante { get; set; }
        public int Cpersona { get; set; }
        public int Calumno { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public string Sestado { get; set; }
        public int? GclasePeriodo { get; set; }
        public string Sorigen { get; set; }
        public DateTime Femision { get; set; }
        public string Celaboracion { get; set; }
        public string Stipo { get; set; }
        public int? Ccontenido { get; set; }
        public int? Cconcepto { get; set; }
        public string Scontenido { get; set; }
        public DateTime Fcontable { get; set; }
        public int Cinteraccion { get; set; }
        public decimal? NmontoPago { get; set; }
        public decimal? NmontoInteres { get; set; }
        public decimal? NmontoGa { get; set; }
        public decimal? NmontoBeneficioInteraccion { get; set; }
        public decimal? NmontoExenta { get; set; }
        public decimal? ImporteImpuesto5 { get; set; }
        public decimal? ImporteImpuesto10 { get; set; }
        public int? Tipofactura { get; set; }
        public int? Grupo { get; set; }
        public int? Formato { get; set; }
        public int? FlagDevolucion { get; set; }
    }
}
