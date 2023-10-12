using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AsientoDiarioDetalleTemp
    {
        public string FechaAsiento { get; set; }
        public int? Id { get; set; }
        public int? CndAsientoControlId { get; set; }
        public int? Calumno { get; set; }
        public string Stipo { get; set; }
        public int? GcondicionVenta { get; set; }
        public int? Cprograma { get; set; }
        public int? GclasePeriodo { get; set; }
        public int? Cconcepto { get; set; }
        public string Dconcepto { get; set; }
        public int? NreferenteANmesCuota { get; set; }
        public int? EsDeTutoria { get; set; }
        public decimal? NmontoPago { get; set; }
        public decimal? NmontoInteres { get; set; }
        public decimal? NmontoGa { get; set; }
        public decimal? NmontoBruto { get; set; }
        public decimal? NmontoImpuesto { get; set; }
        public decimal? NmontoExenta { get; set; }
        public decimal? NmontoBolsa { get; set; }
        public string Cctaco { get; set; }
        public string Dctaco { get; set; }
        public string Grupo { get; set; }
        public string Cingreso { get; set; }
        public int? Cpersona { get; set; }
        public string Sprograma { get; set; }
        public string Dpersona { get; set; }
    }
}
