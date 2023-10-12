using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaCronograma
    {
        public BancaCronograma()
        {
            BancaCronogramaContenidos = new HashSet<BancaCronogramaContenido>();
        }

        public int Ccronograma { get; set; }
        public int Cproducto { get; set; }
        public int Cprecio { get; set; }
        public string Dcronograma { get; set; }
        public string Scronograma { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual ICollection<BancaCronogramaContenido> BancaCronogramaContenidos { get; set; }
    }
}
