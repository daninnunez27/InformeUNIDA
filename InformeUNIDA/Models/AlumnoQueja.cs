using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoQueja
    {
        public int? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public DateTime? Fproceso { get; set; }
        public string Dglosa { get; set; }
        public string Svez { get; set; }
        public string Tcorreo { get; set; }
        public short? Gservicio { get; set; }
        public short? Garea { get; set; }
    }
}
