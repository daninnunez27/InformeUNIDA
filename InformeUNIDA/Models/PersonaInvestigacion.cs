using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaInvestigacion
    {
        public int Cinvestigacion { get; set; }
        public int Cpersona { get; set; }
        public int Cciudad { get; set; }
        public string Stitulo { get; set; }
        public string Sfecha { get; set; }
        public string SautorCoautor { get; set; }
        public string Dinstitucion { get; set; }
        public string Sobservaciones { get; set; }

        public virtual Persona CpersonaNavigation { get; set; }
    }
}
