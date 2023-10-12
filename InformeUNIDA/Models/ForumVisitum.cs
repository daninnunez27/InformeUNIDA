using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ForumVisitum
    {
        public int CforumVisita { get; set; }
        public int? Cforum { get; set; }
        public string TipoPersona { get; set; }
        public int? Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
    }
}
