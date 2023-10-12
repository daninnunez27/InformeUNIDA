using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ExamenIsso
    {
        public int Cexamen { get; set; }
        public int? Cinstitucion { get; set; }
        public string Cprograma { get; set; }
        public string Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public int? Preguntanumero { get; set; }
        public int? Resp1 { get; set; }
        public int? Resp2 { get; set; }
        public int? Resp3 { get; set; }
        public int? Resp4 { get; set; }
        public int? Puntaje { get; set; }
        public int? Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Modulo { get; set; }
    }
}
