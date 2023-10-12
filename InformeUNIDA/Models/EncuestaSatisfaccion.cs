using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaSatisfaccion
    {
        public int Cencuesta { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Codigo { get; set; }
        public string Preguntanumero { get; set; }
        public bool? Resp1 { get; set; }
        public bool? Resp2 { get; set; }
        public bool? Resp3 { get; set; }
        public bool? Resp4 { get; set; }
        public bool? Resp5 { get; set; }
        public bool? Resp6 { get; set; }
        public string Tipopersona { get; set; }
        public int? Ccarrera { get; set; }
        public int? Anio { get; set; }
        public string Texto1 { get; set; }
        public string Texto2 { get; set; }
        public DateTime? Fecharegistro { get; set; }
        public string Cuestionario { get; set; }
        public int NumeroEncuesta { get; set; }
    }
}
