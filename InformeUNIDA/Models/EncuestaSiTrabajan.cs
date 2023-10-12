using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaSiTrabajan
    {
        public int Cencuesta { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public string Modulo { get; set; }
        public int Codigo { get; set; }
        public int Preguntanumero { get; set; }
        public string Trabaja { get; set; }
        public string Sector { get; set; }
        public DateTime? Fecharegistro { get; set; }
    }
}
