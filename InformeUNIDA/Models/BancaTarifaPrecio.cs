using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaTarifaPrecio
    {
        public int Ctarifa { get; set; }
        public int Cprecio { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual BancaPrecio CprecioNavigation { get; set; }
        public virtual BancaTarifa CtarifaNavigation { get; set; }
    }
}
