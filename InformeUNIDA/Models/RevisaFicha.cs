using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class RevisaFicha
    {
        public int? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public string Cingreso { get; set; }
        public int? Ccurso { get; set; }
        public string Scurso { get; set; }
        public string Dcurso { get; set; }
        public int? Cbloque { get; set; }
        public string Dbloque { get; set; }
    }
}
