using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LyTurma
    {
        public string Disciplina { get; set; }
        public string Turma { get; set; }
        public decimal Ano { get; set; }
        public decimal Semestre { get; set; }
        public string Faculdade { get; set; }
        public string Dependencia { get; set; }
        public decimal? NumFunc { get; set; }
        public string Turno { get; set; }
        public string Curso { get; set; }
        public string Curriculo { get; set; }
        public decimal? Serie { get; set; }
        public decimal AulasPrevistas { get; set; }
        public decimal MinAulas { get; set; }
        public decimal? NumAlunos { get; set; }
        public DateTime DtUltalt { get; set; }
        public string FormulaMf1 { get; set; }
        public string FormulaMf2 { get; set; }
        public string ConceitoMin1 { get; set; }
        public string ConceitoMin2 { get; set; }
        public string ConceitoMinEx { get; set; }
        public DateTime DtInicio { get; set; }
        public DateTime DtFim { get; set; }
        public string SitTurma { get; set; }
        public string Nivel { get; set; }
        public decimal? AulasDadas { get; set; }
        public string FormulaMf3 { get; set; }
        public string FormulaCa1 { get; set; }
        public string FormulaCa2 { get; set; }
        public string FormulaCa3 { get; set; }
        public string ConceitoMin3 { get; set; }
        public string ConceitoMinEx2 { get; set; }
        public string UnidadeResponsavel { get; set; }
        public string Especial { get; set; }
        public string UtilizaIndice { get; set; }
        public string TemHorario { get; set; }
        public decimal? UltNumChamada { get; set; }
        public string NivelPresenca { get; set; }
        public string ExibeSomenteListaSel { get; set; }
        public string LancamentoHistorico { get; set; }
    }
}
