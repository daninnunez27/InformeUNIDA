using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoSeguroMed
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Calumno { get; set; }
        public int Cpersona { get; set; }
        public string Cingreso { get; set; }
        public string Cpoliza { get; set; }
        public DateTime Fdesde { get; set; }
        public DateTime Fhasta { get; set; }
    }
}
