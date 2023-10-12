using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TAp1
    {
        public string Cingreso { get; set; }
        public short Gcondicion { get; set; }
        public short Gestado { get; set; }
        public int? Cobligacion { get; set; }
        public int? Ccronograma { get; set; }
        public decimal? NmontoCuotaCn { get; set; }
        public decimal? NmontoCuotaCp { get; set; }
        public decimal? NmontoCuotaBruto { get; set; }
        public decimal? NmontoDescuento { get; set; }
        public decimal? NmontoCuotaNetoPagar { get; set; }
        public decimal? AIntereses { get; set; }
        public decimal? AGastoadm { get; set; }
        public decimal? APerdidaBe { get; set; }
        public decimal? BAutoriBe { get; set; }
        public decimal? BAutoriGa { get; set; }
        public decimal? BAutoriIn { get; set; }
        public decimal? CPago { get; set; }
        public decimal? CPagoCuentaAf { get; set; }
        public decimal? CPagoCuentaDf { get; set; }
        public decimal? CAjustePago { get; set; }
        public decimal? DEmision { get; set; }
        public decimal? DBeneficio { get; set; }
    }
}
