using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoNota
    {
        public int? Nregistro { get; set; }
        public int? Calumno { get; set; }
        public int? Cperiodo { get; set; }
        public int? Ccurricula { get; set; }
        public int? Ccurso { get; set; }
        public string Scurso { get; set; }
        public short? GtipoAprobacion { get; set; }
        public short? Gaprobado { get; set; }
        public string Gmuestra { get; set; }
    }
}
