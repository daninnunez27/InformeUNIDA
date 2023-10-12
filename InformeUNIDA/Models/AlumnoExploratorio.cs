using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoExploratorio
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Calumno { get; set; }
        public int Ccurso { get; set; }
        public DateTime Fecha { get; set; }
        public short? Gaprobacion { get; set; }
        public decimal? Npuntaje { get; set; }
    }
}
