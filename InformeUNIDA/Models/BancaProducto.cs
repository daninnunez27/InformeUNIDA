using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaProducto
    {
        public BancaProducto()
        {
            BancaProductoContenidos = new HashSet<BancaProductoContenido>();
        }

        public int Cproducto { get; set; }
        public string Dproducto { get; set; }
        public string Sproducto { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual ICollection<BancaProductoContenido> BancaProductoContenidos { get; set; }
    }
}
