using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Ly2Notahist0909
    {
        public string Aluno { get; set; }
        public decimal Ordem { get; set; }
        public decimal Ano { get; set; }
        public decimal Semestre { get; set; }
        public string Disciplina { get; set; }
        public string NotaId { get; set; }
        public string Conceito { get; set; }
        public DateTime? Data { get; set; }
        public string Observacao { get; set; }
        public string Compareceu { get; set; }
    }
}
