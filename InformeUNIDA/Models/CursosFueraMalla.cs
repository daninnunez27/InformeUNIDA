using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CursosFueraMalla
    {
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public int Ccurso { get; set; }
        public int Ccarrera { get; set; }
        public string Speriodo { get; set; }
        public string Cingreso { get; set; }
        public string Dcarrera { get; set; }
        public string Dpersona { get; set; }
        public string Scurso { get; set; }
        public string Dcurso { get; set; }
        public decimal? Npromedio { get; set; }
        public int? GtipoAprobacion { get; set; }
        public int? Gaprobado { get; set; }
    }
}
