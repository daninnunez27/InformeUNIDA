using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Estructura
    {
        public Estructura()
        {
            Clasificacions = new HashSet<Clasificacion>();
            Columnas = new HashSet<Columna>();
        }

        public int Cestructura { get; set; }
        public string Destructura { get; set; }

        public virtual ICollection<Clasificacion> Clasificacions { get; set; }
        public virtual ICollection<Columna> Columnas { get; set; }
    }
}
