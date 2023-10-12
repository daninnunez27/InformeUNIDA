using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaObligacionContenido
    {
        public BancaObligacionContenido()
        {
            BancaObligacionMovimientos = new HashSet<BancaObligacionMovimiento>();
        }

        public int Cobligacion { get; set; }
        public int Ccontenido { get; set; }
        public DateTime? Fvencimiento { get; set; }
        public string Sestado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string TsystemUser { get; set; }
        public DateTime Fcontable { get; set; }
        public decimal? FNmontoBaseSaldoCalc { get; set; }
        public decimal? NmontoCuotaCn { get; set; }
        public decimal? NmontoCuotaCp { get; set; }
        public decimal? NmontoCuotaBruto { get; set; }
        public decimal? NmontoBeneficioCalculado { get; set; }
        public decimal? NmontoCuotaNetoPagar { get; set; }
        public decimal? Imoras { get; set; }
        public decimal? Igasto { get; set; }
        public decimal? Isaldo { get; set; }
        public decimal? IsaldoDw { get; set; }
        public string Caprobacion { get; set; }
        public DateTime? Faprobacion { get; set; }

        public virtual BancaContenido CcontenidoNavigation { get; set; }
        public virtual BancaObligacion CobligacionNavigation { get; set; }
        public virtual ICollection<BancaObligacionMovimiento> BancaObligacionMovimientos { get; set; }
    }
}
