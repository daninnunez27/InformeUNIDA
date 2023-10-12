using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CalendarioEclass
    {
        public int? Cprograma { get; set; }
        public int Ccalendario { get; set; }
        public DateTime? Ffecha { get; set; }
        public string Tfecha { get; set; }
        public int? Guso { get; set; }
        public decimal? Nvalor { get; set; }
        public string ColorEvento { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
