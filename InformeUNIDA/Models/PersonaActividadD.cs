using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaActividadD
    {
        public int Cpersona { get; set; }
        public short Norden { get; set; }
        public int Cactividad { get; set; }
        public DateTime? Fgestion { get; set; }
        public string Cgestor { get; set; }
        public short? Crespuesta { get; set; }
        public short? Csubrespuesta { get; set; }
        public DateTime? Finscripcion { get; set; }
        public string Dglosa { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
