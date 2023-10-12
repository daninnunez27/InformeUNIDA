using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Dato
    {
        public int Cdato { get; set; }
        public int Cclasificacion { get; set; }
        public int Ccolumna { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Tdato { get; set; }

        public virtual Clasificacion CclasificacionNavigation { get; set; }
        public virtual Columna CcolumnaNavigation { get; set; }
    }
}
