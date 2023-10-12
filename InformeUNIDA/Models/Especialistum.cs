using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Especialistum
    {
        public Especialistum()
        {
            Consulta = new HashSet<Consultum>();
        }

        public int Cespecialista { get; set; }
        public int Cpersona { get; set; }
        public string Stipo { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual Persona CpersonaNavigation { get; set; }
        public virtual ICollection<Consultum> Consulta { get; set; }
    }
}
