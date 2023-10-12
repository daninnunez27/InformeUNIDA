using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SeguimientoAlumnoMatriculado
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public int Semana { get; set; }
        public int AccionNro { get; set; }
        public int? Caccion { get; set; }
        public string Accion { get; set; }
        public string AccionUcreacion { get; set; }
        public DateTime? AccionFcreacion { get; set; }
        public string AccionUmodificacion { get; set; }
        public DateTime? AccionFmodificacion { get; set; }
    }
}
