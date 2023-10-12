using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ControlAccesosVista
    {
        public int IdRegistro { get; set; }
        public int? Cinsitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public string Tipousuario { get; set; }
        public int? Cpersona { get; set; }
        public string Dvista { get; set; }
        public DateTime? Fregistro { get; set; }
    }
}
