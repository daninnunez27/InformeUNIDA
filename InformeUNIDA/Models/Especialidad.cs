using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Especialidad
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public short? Ccarrera { get; set; }
        public int Cespecialidad { get; set; }
        public string Despecialidad { get; set; }
        public string Sespecialidad { get; set; }
        public string Cresponsabilidad { get; set; }

        public virtual Carrera CcarreraNavigation { get; set; }
    }
}
