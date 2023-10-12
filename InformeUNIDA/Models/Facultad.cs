using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Facultad
    {
        public Facultad()
        {
            Carreras = new HashSet<Carrera>();
        }

        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cfacultad { get; set; }
        public string Dfacultad { get; set; }
        public string Sfacultad { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual ICollection<Carrera> Carreras { get; set; }
    }
}
