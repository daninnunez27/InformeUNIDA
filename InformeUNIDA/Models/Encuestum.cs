using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Encuestum
    {
        public int Cencuesta { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Cbloque { get; set; }
        public int Ccurso { get; set; }
        public int Calumno { get; set; }
        public int Cprofesor { get; set; }
        public int Preguntanumero { get; set; }
        public bool? Resp1 { get; set; }
        public bool? Resp2 { get; set; }
        public bool? Resp3 { get; set; }
        public bool? Resp4 { get; set; }
        public bool? Resp5 { get; set; }
        public bool? Resp6 { get; set; }
        public int Ccarrera { get; set; }
        public DateTime? Fecharegistro { get; set; }
        public string Cuestionario { get; set; }
        public string Profesor { get; set; }
        public string Scurso { get; set; }
    }
}
