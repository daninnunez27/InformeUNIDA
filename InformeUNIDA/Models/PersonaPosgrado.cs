using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaPosgrado
    {
        public int Cpersona { get; set; }
        public int Cposgrado { get; set; }
        public string Sdenominacion { get; set; }
        public decimal Nano { get; set; }
        public string TesisAprobada { get; set; }
        public string Sobservaciones { get; set; }
        public short Ceducativo { get; set; }

        public virtual Persona CpersonaNavigation { get; set; }
    }
}
