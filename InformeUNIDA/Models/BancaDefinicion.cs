using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaDefinicion
    {
        public BancaDefinicion()
        {
            BancaPrecioDefinicions = new HashSet<BancaPrecioDefinicion>();
        }

        public int Cdefinicion { get; set; }
        public string Ddefinicion { get; set; }
        public string Sdefinicion { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual ICollection<BancaPrecioDefinicion> BancaPrecioDefinicions { get; set; }
    }
}
