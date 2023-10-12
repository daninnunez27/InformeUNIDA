using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaIdioma
    {
        public int Cpersona { get; set; }
        public int Cidioma { get; set; }
        public short Ceducativo { get; set; }
        public string Cnivel { get; set; }
        public string Sfecha { get; set; }
        public string Sobservaciones { get; set; }

        public virtual EnteEducativo CeducativoNavigation { get; set; }
        public virtual Persona CpersonaNavigation { get; set; }
    }
}
