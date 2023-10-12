using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LyFaltaHistmatr
    {
        public string Aluno { get; set; }
        public decimal Ordem { get; set; }
        public decimal Ano { get; set; }
        public decimal Semestre { get; set; }
        public string Disciplina { get; set; }
        public string FreqId { get; set; }
        public decimal Faltas { get; set; }
    }
}
