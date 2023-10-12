using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TLyfic
    {
        public string Aluno { get; set; }
        public string Disciplina { get; set; }
        public string Turma { get; set; }
        public decimal Ano { get; set; }
        public decimal Semestre { get; set; }
    }
}
