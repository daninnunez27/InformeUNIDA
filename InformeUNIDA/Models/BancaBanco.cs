using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaBanco
    {
        public BancaBanco()
        {
            BancaObligacionMovimientoPagos = new HashSet<BancaObligacionMovimientoPago>();
        }

        public int Cbanco { get; set; }
        public string Dbanco { get; set; }
        public string Sbanco { get; set; }
        public string Gtipo { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual ICollection<BancaObligacionMovimientoPago> BancaObligacionMovimientoPagos { get; set; }
    }
}
