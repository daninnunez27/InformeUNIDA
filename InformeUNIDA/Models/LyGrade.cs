using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LyGrade
    {
        public string Curso { get; set; }
        public string Turno { get; set; }
        public string Curriculo { get; set; }
        public string Disciplina { get; set; }
        public decimal? SeriePrereq { get; set; }
        public decimal SerieIdeal { get; set; }
        public string Obrigatoria { get; set; }
        public string FormulaPrereq { get; set; }
        public string FormulaEquiv { get; set; }
        public string RetemSerie { get; set; }
        public decimal MaxMatrAprov { get; set; }
        public decimal? MaxReprov { get; set; }
        public string DisciplinaExtensiva { get; set; }
        public string NomeExibicao { get; set; }
        public string Complemento { get; set; }
        public decimal? AulasSemanais { get; set; }
        public decimal? AulasSemAula { get; set; }
        public decimal? AulasSemLab { get; set; }
        public decimal? AulasSemAtiv { get; set; }
        public int? Ccurricula { get; set; }
    }
}
