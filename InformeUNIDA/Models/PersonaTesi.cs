using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaTesi
    {
        public int Ctesis { get; set; }
        public int Cpersona { get; set; }
        public short Ceducativo { get; set; }
        public string DtituloTesis { get; set; }
        public decimal Nano { get; set; }
        public string Sobservaciones { get; set; }

        public virtual Persona CpersonaNavigation { get; set; }
    }
}
