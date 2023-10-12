using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TAp11
    {
        public string Cingreso { get; set; }
        public short Gcondicion { get; set; }
        public short Gestado { get; set; }
        public int? Cobligacion { get; set; }
        public int? Ccronograma { get; set; }
        public decimal? NmontoCuotaCn { get; set; }
        public decimal? NmontoCuotaCp { get; set; }
        public decimal? NmontoCuotaBruto { get; set; }
        public decimal NmontoBeneficioCalculado { get; set; }
        public decimal? NmontoCuotaNetoPagar { get; set; }
        public decimal? AIntereses { get; set; }
        public decimal? AGastoadm { get; set; }
        public decimal? CPago { get; set; }
        public decimal? CIntereses { get; set; }
        public decimal? CGastoadm { get; set; }
        public decimal? CPagoCuentaAf { get; set; }
        public decimal? CPagoCuentaDf { get; set; }
        public decimal? CAjustePago { get; set; }
        public decimal? RecAutoriGa { get; set; }
        public decimal? RecAutoriIn { get; set; }
        public decimal? RecEmision { get; set; }
        public decimal? RecPerdidaBe { get; set; }
        public decimal? SaldoOperacion { get; set; }
        public decimal MasBeneficioCalculado2 { get; set; }
        public decimal MenosBeneficioRegistrado { get; set; }
        public decimal MenosAutoriBe { get; set; }
        public decimal? SaldoFinal { get; set; }
        public DateTime? Fnacimiento { get; set; }
        public string NdocIdentidad { get; set; }
    }
}
