using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EvaluacionEntradum
    {
        public int Cevaluacion { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public string Preguntanumero { get; set; }
        public int? Resp1 { get; set; }
        public int? Resp2 { get; set; }
        public int? Resp3 { get; set; }
        public int? Resp4 { get; set; }
        public int? Resp5 { get; set; }
        public decimal? ResultadoPorciento { get; set; }
        public int? NumeroIntentos { get; set; }
        public int? Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
    }
}
