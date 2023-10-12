using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TAc
    {
        public string Speriodo { get; set; }
        public string Cingreso { get; set; }
        public string Dpersona { get; set; }
        public string Scurso { get; set; }
        public string Dcurso { get; set; }
        public string Taccion { get; set; }
        public decimal? NpromedioR2 { get; set; }
        public int? GaprobadoR2 { get; set; }
        public string Toperacion { get; set; }
        public int? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public int? Ccurso { get; set; }
        public int? Vale { get; set; }
        public string Tcomentario { get; set; }
    }
}
