using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Ly2Hismat9
    {
        public string Aluno { get; set; }
        public decimal Ordem { get; set; }
        public decimal Ano { get; set; }
        public decimal Semestre { get; set; }
        public string Disciplina { get; set; }
        public string Turma { get; set; }
        public string NotaFinal { get; set; }
        public string SituacaoHist { get; set; }
        public decimal? PercPresenca { get; set; }
        public decimal? HorasAula { get; set; }
        public decimal? Creditos { get; set; }
        public string NomeDiscOrig { get; set; }
        public decimal? AulasDadas { get; set; }
        public string Observacao { get; set; }
        public decimal? NumFunc { get; set; }
        public decimal? LancDeb { get; set; }
        public decimal? AulasPrevistas { get; set; }
        public string Subturma1 { get; set; }
        public string Subturma2 { get; set; }
        public decimal? NumChamada { get; set; }
        public string NivelPresenca { get; set; }
        public decimal? Serie { get; set; }
        public string GrupoEletiva { get; set; }
        public string SitDetalhe { get; set; }
        public DateTime? DtInicio { get; set; }
        public DateTime? DtFim { get; set; }
        public string CobrancaSep { get; set; }
        public DateTime? DtUltalt { get; set; }
        public DateTime? DtMatricula { get; set; }
    }
}
