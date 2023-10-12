using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class MatriculaAlumnoTurno
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public DateTime Hora { get; set; }
        public decimal? Dia1 { get; set; }
        public decimal? Dia2 { get; set; }
        public decimal? Dia3 { get; set; }
        public decimal? Dia4 { get; set; }
    }
}
