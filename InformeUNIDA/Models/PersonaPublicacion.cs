using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaPublicacion
    {
        public int Cpersona { get; set; }
        public int Cpublicacion { get; set; }
        public string Stitulo { get; set; }
        public string Seditorial { get; set; }
        public string Sfecha { get; set; }
        public string SautorCoautor { get; set; }
        public string Sobservaciones { get; set; }

        public virtual Persona CpersonaNavigation { get; set; }
    }
}
