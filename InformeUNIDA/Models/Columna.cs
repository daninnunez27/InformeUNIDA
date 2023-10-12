using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Columna
    {
        public Columna()
        {
            Datos = new HashSet<Dato>();
        }

        public int Ccolumna { get; set; }
        public int Cestructura { get; set; }
        public string Scolumna { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Dcolumna { get; set; }
        public int? Norden { get; set; }

        public virtual Estructura CestructuraNavigation { get; set; }
        public virtual ICollection<Dato> Datos { get; set; }
    }
}
