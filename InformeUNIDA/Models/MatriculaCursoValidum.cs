using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class MatriculaCursoValidum
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Ccurso { get; set; }
        public int Calumno { get; set; }
        public string Gtipo { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
    }
}
