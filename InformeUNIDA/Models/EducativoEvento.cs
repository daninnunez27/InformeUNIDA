using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EducativoEvento
    {
        public short Ceducativo { get; set; }
        public short Gevento { get; set; }
        public DateTime? Fevento { get; set; }
        public string Tactividad { get; set; }
        public string Tobservacion { get; set; }
        public string Dpaterno { get; set; }
        public string Dmaterno { get; set; }
        public string Dnombre { get; set; }
        public string Tcorreo { get; set; }
        public int? Nficha { get; set; }
    }
}
