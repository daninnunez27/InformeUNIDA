using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SumAlumnoXEgresar2
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Ccarrera { get; set; }
        public int Cespecialidad { get; set; }
        public int Calumno { get; set; }
        public int Cpersona { get; set; }
        public string Cingreso { get; set; }
        public int Ccurricula { get; set; }
        public int QcursosPend { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
