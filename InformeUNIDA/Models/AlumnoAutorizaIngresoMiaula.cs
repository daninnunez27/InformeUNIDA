using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoAutorizaIngresoMiaula
    {
        public int Codigo { get; set; }
        public int? Calumno { get; set; }
        public string Cingreso { get; set; }
        public string Motivo { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public int? Estado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
