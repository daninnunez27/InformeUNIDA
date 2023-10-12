using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaProductoContenido
    {
        public int Cproducto { get; set; }
        public int Ccontenido { get; set; }
        public int Nsecuencia { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual BancaContenido CcontenidoNavigation { get; set; }
        public virtual BancaProducto CproductoNavigation { get; set; }
    }
}
