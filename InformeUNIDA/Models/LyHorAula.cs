using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LyHorAula
    {
        public string Turno { get; set; }
        public string Faculdade { get; set; }
        public decimal DiaSemana { get; set; }
        public decimal Aula { get; set; }
        public string Disciplina { get; set; }
        public string Turma { get; set; }
        public decimal Ano { get; set; }
        public decimal Semestre { get; set; }
        public string Dependencia { get; set; }
        public string Tipo { get; set; }
        public string Frequencia { get; set; }
        public DateTime? HorainiAula { get; set; }
        public DateTime? HorafimAula { get; set; }
        public string Curso { get; set; }
        public int? Ccarrera { get; set; }
    }
}
