using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ServiciosUnidum
    {
        public int Idservicio { get; set; }
        public int? Calumno { get; set; }
        public int? Cperiodo { get; set; }
        public int? Cservicio { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? Autorizado { get; set; }
    }
}
