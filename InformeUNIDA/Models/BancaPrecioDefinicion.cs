using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaPrecioDefinicion
    {
        public int Cprecio { get; set; }
        public int Cdefinicion { get; set; }
        public int Ncantidad { get; set; }
        public decimal Nprecio { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string TsystemUser { get; set; }

        public virtual BancaDefinicion CdefinicionNavigation { get; set; }
        public virtual BancaPrecio CprecioNavigation { get; set; }
    }
}
