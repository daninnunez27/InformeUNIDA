using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LyMat
    {
        public string Aluno { get; set; }
        public string Disciplina { get; set; }
        public string Turma { get; set; }
        public decimal Ano { get; set; }
        public decimal Semestre { get; set; }
        public string SitMatricula { get; set; }
        public string ConceitoFim { get; set; }
        public decimal? TotAulas { get; set; }
        public string Obs { get; set; }
        public decimal? PercPresfim { get; set; }
        public decimal? LancDeb { get; set; }
        public DateTime DtUltalt { get; set; }
        public string Subturma1 { get; set; }
        public string Subturma2 { get; set; }
        public string CobrancaSep { get; set; }
        public decimal? ConceitoFimNum { get; set; }
        public string SitDetalhe { get; set; }
        public decimal? SerieCalculo { get; set; }
        public DateTime? DtInsercao { get; set; }
        public DateTime? DtMatricula { get; set; }
        public decimal? NumChamada { get; set; }
        public string GrupoEletiva { get; set; }
    }
}
