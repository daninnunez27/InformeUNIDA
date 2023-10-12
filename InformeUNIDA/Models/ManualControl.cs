using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ManualControl
    {
        public short? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public int? Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public int? Calumno { get; set; }
        public int? Cpersona { get; set; }
        public string Dcurso { get; set; }
        public string Dbloque { get; set; }
        public string Cingreso { get; set; }
        public string Dpersona { get; set; }
        public DateTime? Fecha { get; set; }
        public string Tentrega { get; set; }
        public string Speriodo { get; set; }
    }
}
