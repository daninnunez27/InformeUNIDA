using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaTitulo
    {
        public int Cpersona { get; set; }
        public short Ctitulo { get; set; }
        public short Ceducativo { get; set; }
        public decimal Nano { get; set; }
        public string Sobservaciones { get; set; }

        public virtual Persona CpersonaNavigation { get; set; }
    }
}
