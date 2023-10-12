using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LogEnviarCorreoUnidum
    {
        public int IdCorreo { get; set; }
        public int? Calumno { get; set; }
        public string Tcorreo { get; set; }
        public int? Cenvio { get; set; }
        public int? Ctanda { get; set; }
    }
}
