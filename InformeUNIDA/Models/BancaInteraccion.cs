using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaInteraccion
    {
        public BancaInteraccion()
        {
            BancaComprobantes = new HashSet<BancaComprobante>();
            BancaInteraccionCursos = new HashSet<BancaInteraccionCurso>();
            BancaObligacionMovimientoPagos = new HashSet<BancaObligacionMovimientoPago>();
            BancaObligacionMovimientos = new HashSet<BancaObligacionMovimiento>();
        }

        public int Cinteraccion { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual ICollection<BancaComprobante> BancaComprobantes { get; set; }
        public virtual ICollection<BancaInteraccionCurso> BancaInteraccionCursos { get; set; }
        public virtual ICollection<BancaObligacionMovimientoPago> BancaObligacionMovimientoPagos { get; set; }
        public virtual ICollection<BancaObligacionMovimiento> BancaObligacionMovimientos { get; set; }
    }
}
