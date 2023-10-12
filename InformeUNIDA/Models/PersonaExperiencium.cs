using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaExperiencium
    {
        public int Cexperiencia { get; set; }
        public int Cpersona { get; set; }
        public short Ceducativo { get; set; }
        public string Scargo { get; set; }
        public int Ccarrera { get; set; }
        public string Smateria { get; set; }
        public string Speriodo { get; set; }
        public string Sobservaciones { get; set; }
        public string Smodalidad { get; set; }

        public virtual EnteEducativo CeducativoNavigation { get; set; }
        public virtual Persona CpersonaNavigation { get; set; }
    }
}
