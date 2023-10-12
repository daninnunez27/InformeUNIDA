using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaObligacionMora
    {
        public int Cobligacion { get; set; }
        public int Ccontenido { get; set; }
        public int Ninterno { get; set; }
        public DateTime? Fvencimiento { get; set; }
        public decimal? FNmontoBaseSaldoCalc { get; set; }
        public decimal? NmontoCuotaCn { get; set; }
        public decimal? NmontoCuotaCp { get; set; }
        public decimal? NmontoCuotaBruto { get; set; }
        public decimal? NmontoBeneficioCalculado { get; set; }
        public decimal? NmontoCuotaNetoPagar { get; set; }
        public decimal? Imoras { get; set; }
        public decimal? Igasto { get; set; }
        public decimal? ImorasRebaja { get; set; }
        public decimal? IgastoRebaja { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Mdescripcion { get; set; }
    }
}
