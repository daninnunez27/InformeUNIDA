using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaContenido
    {
        public BancaContenido()
        {
            BancaCronogramaContenidos = new HashSet<BancaCronogramaContenido>();
            BancaObligacionBeneficios = new HashSet<BancaObligacionBeneficio>();
            BancaObligacionContenidos = new HashSet<BancaObligacionContenido>();
            BancaObligacionMovimientoPagos = new HashSet<BancaObligacionMovimientoPago>();
            BancaProductoContenidos = new HashSet<BancaProductoContenido>();
        }

        public int Ccontenido { get; set; }
        public int Cconcepto { get; set; }
        public string Dcontenido { get; set; }
        public string Scontenido { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string SmomentoAplicacionImpuesto { get; set; }
        public int? GtipoNota { get; set; }
        public decimal? Precio { get; set; }
        public int? Habilitado { get; set; }
        public string Gvisible { get; set; }

        public virtual BancaConcepto CconceptoNavigation { get; set; }
        public virtual ICollection<BancaCronogramaContenido> BancaCronogramaContenidos { get; set; }
        public virtual ICollection<BancaObligacionBeneficio> BancaObligacionBeneficios { get; set; }
        public virtual ICollection<BancaObligacionContenido> BancaObligacionContenidos { get; set; }
        public virtual ICollection<BancaObligacionMovimientoPago> BancaObligacionMovimientoPagos { get; set; }
        public virtual ICollection<BancaProductoContenido> BancaProductoContenidos { get; set; }
    }
}
