using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ConcursoV
    {
        public int GrupoId { get; set; }
        public string Par1 { get; set; }
        public string Par2 { get; set; }
        public string Par3 { get; set; }
        public string Par4 { get; set; }
        public string Par5 { get; set; }
        public DateTime? Fcreacion { get; set; }
    }
}
