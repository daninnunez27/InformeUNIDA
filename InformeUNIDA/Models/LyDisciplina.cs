using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LyDisciplina
    {
        public string Disciplina { get; set; }
        public string Faculdade { get; set; }
        public string Depto { get; set; }
        public string Nome { get; set; }
        public string NomeCompl { get; set; }
        public decimal Creditos { get; set; }
        public string TemNota { get; set; }
        public string TipoNota { get; set; }
        public string TemFreq { get; set; }
        public string PriorizaFreq { get; set; }
        public string VerificaHorario { get; set; }
        public string Ativa { get; set; }
        public string FormulaMf1 { get; set; }
        public string FormulaMf2 { get; set; }
        public string ConceitoMin1 { get; set; }
        public string ConceitoMin2 { get; set; }
        public string ConceitoMinEx { get; set; }
        public decimal? PercPresmin { get; set; }
        public string Servico { get; set; }
        public string Estagio { get; set; }
        public decimal? HorasAula { get; set; }
        public decimal? HorasLab { get; set; }
        public decimal? HorasEstagio { get; set; }
        public decimal PrazoRevisao { get; set; }
        public string FormulaPrereq { get; set; }
        public string FormulaEquiv { get; set; }
        public string Tipo { get; set; }
        public string GrupoNota { get; set; }
        public string GrupoMedia { get; set; }
        public decimal? NCasasDec { get; set; }
        public string NotaMax { get; set; }
        public decimal? NCasasDecMedia { get; set; }
        public string NotaMaxMedia { get; set; }
        public decimal? AulasSemanais { get; set; }
        public decimal? AulasSemAula { get; set; }
        public decimal? AulasSemLab { get; set; }
        public decimal? AulasSemAtiv { get; set; }
        public decimal? HorasAtiv { get; set; }
        public string FormulaMf3 { get; set; }
        public string FormulaCa1 { get; set; }
        public string FormulaCa2 { get; set; }
        public string FormulaCa3 { get; set; }
        public string ConceitoMin3 { get; set; }
        public string ConceitoMinEx2 { get; set; }
        public string TruncaMedia { get; set; }
        public string FaltaDiaria { get; set; }
        public decimal? PrazoDivulgacao { get; set; }
        public string CopiaNotaSubturma { get; set; }
        public string Pim { get; set; }
    }
}
