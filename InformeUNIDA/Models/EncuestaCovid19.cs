using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaCovid19
    {
        public int Cencuesta { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public string Modulo { get; set; }
        public int Codigo { get; set; }
        public int Preguntanumero { get; set; }
        public bool? Resp1 { get; set; }
        public bool? Resp2 { get; set; }
        public bool? Resp3 { get; set; }
        public int? Ccarrera { get; set; }
        public int? Nciclo { get; set; }
        public DateTime? Fecharegistro { get; set; }
    }
}
