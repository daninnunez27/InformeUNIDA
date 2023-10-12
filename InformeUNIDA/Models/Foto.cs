using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Foto
    {
        public int Cpersona { get; set; }
        public byte[] Tfoto { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual Persona CpersonaNavigation { get; set; }
    }
}
