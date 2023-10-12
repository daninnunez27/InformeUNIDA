using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Asiento01
    {
        public int? Nproceso { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public string DcondVenta { get; set; }
        public string GcondicionVenta { get; set; }
        public string Stipo { get; set; }
        public int? Ccomprobante { get; set; }
        public int? Nnumero { get; set; }
        public string Celaboracion { get; set; }
        public DateTime? Fpago { get; set; }
        public string Tsolicitante { get; set; }
        public string Tcarrera { get; set; }
        public string Cingreso { get; set; }
        public DateTime? Fvencimiento { get; set; }
        public DateTime? Fcontable { get; set; }
        public int? Ccontenido { get; set; }
        public string Scontenido { get; set; }
        public decimal? NmontoPago { get; set; }
        public decimal? NmontoInteres { get; set; }
        public decimal? NmontoGa { get; set; }
        public decimal? NmontoBruto { get; set; }
        public decimal? NmontoImpuesto { get; set; }
        public decimal? NmontoExenta { get; set; }
        public decimal? NmontoBolsa { get; set; }
        public decimal? NmontoTotal { get; set; }
        public decimal? ImporteImpuesto5 { get; set; }
        public decimal? ImporteImpuesto10 { get; set; }
        public decimal? MontoBeneficioInteraccion { get; set; }
        public DateTime? Femision { get; set; }
        public int? Calumno { get; set; }
        public int? GclasePeriodo { get; set; }
        public int? Cconcepto { get; set; }
        public int? NreferenteANmesCuota { get; set; }
        public int? EsDeTutoria { get; set; }
        public string Dinstitucion { get; set; }
        public string Dprograma { get; set; }
        public string Dperiodo { get; set; }
        public string Dconcepto { get; set; }
        public string Cctaco { get; set; }
        public string CctacoD { get; set; }
        public string CctacoH { get; set; }
    }
}
