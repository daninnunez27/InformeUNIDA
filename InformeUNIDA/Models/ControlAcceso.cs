using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ControlAcceso
    {
        public long Id { get; set; }
        public string Susuario { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Ccarrera { get; set; }
        public int? Calumno { get; set; }
        public string Cingreso { get; set; }
        public string Ip { get; set; }
        public DateTime? Fregistro { get; set; }
    }
}
