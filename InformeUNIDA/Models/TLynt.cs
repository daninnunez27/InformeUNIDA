using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TLynt
    {
        public string Alumno { get; set; }
        public int? Ano { get; set; }
        public int? Semestre { get; set; }
        public string Disciplina { get; set; }
        public decimal? NotaFinal { get; set; }
    }
}
