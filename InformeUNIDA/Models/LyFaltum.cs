using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LyFaltum
    {
        public string Aluno { get; set; }
        public string Disciplina { get; set; }
        public string Turma { get; set; }
        public decimal Ano { get; set; }
        public decimal Periodo { get; set; }
        public string Freq { get; set; }
        public decimal Faltas { get; set; }
        public decimal? FaltasCompensadas { get; set; }
    }
}
