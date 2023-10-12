using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaPrecio
    {
        public BancaPrecio()
        {
            BancaPrecioDefinicions = new HashSet<BancaPrecioDefinicion>();
            BancaTarifaPrecios = new HashSet<BancaTarifaPrecio>();
        }

        public int Cprecio { get; set; }
        public string Dprecio { get; set; }
        public string Sprecio { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string StipoPrecio { get; set; }

        public virtual ICollection<BancaPrecioDefinicion> BancaPrecioDefinicions { get; set; }
        public virtual ICollection<BancaTarifaPrecio> BancaTarifaPrecios { get; set; }
    }
}
