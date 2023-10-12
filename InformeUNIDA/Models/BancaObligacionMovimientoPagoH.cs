using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaObligacionMovimientoPagoH
    {
        public int Cpago { get; set; }
        public int Cinteraccion { get; set; }
        public int Cobligacion { get; set; }
        public int Ccontenido { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public DateTime? Fvencimiento { get; set; }
        public string TtipoPago { get; set; }
        public int? Cbanco { get; set; }
        public string Tnumero { get; set; }
        public decimal? NmontoBruto { get; set; }
        public decimal? NmontoBeneficio { get; set; }
        public decimal? NmontoMora { get; set; }
        public decimal? NmontoGasto { get; set; }
        public decimal? NmontoSaldo { get; set; }
        public decimal NmontoPago { get; set; }
        public DateTime Fpago { get; set; }
        public int? Cnotacredeb { get; set; }
        public string GtipoTarjeta { get; set; }
        public string GclaseTarjeta { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Tipo { get; set; }
        public DateTime? Fauditoria { get; set; }
    }
}
