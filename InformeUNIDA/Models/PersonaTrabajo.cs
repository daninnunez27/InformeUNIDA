using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaTrabajo
    {
        public int Cpersona { get; set; }
        public int Ctrabajo { get; set; }
        public string Sorganizacion { get; set; }
        public string Stipo { get; set; }
        public string Starea { get; set; }
        public decimal Nano { get; set; }

        public virtual Persona CpersonaNavigation { get; set; }
    }
}
