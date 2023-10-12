using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaCongreso
    {
        public int Cpersona { get; set; }
        public int Ccongreso { get; set; }
        public string Sdenominacion { get; set; }
        public string Dinstitucion { get; set; }
        public int Cciudad { get; set; }
        public string Sfecha { get; set; }
        public string CalidadDe { get; set; }
        public string Sobservaciones { get; set; }

        public virtual Persona CpersonaNavigation { get; set; }
    }
}
