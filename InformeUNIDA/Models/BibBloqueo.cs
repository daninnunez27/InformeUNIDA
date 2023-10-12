using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BibBloqueo
    {
        public int Cbloqueo { get; set; }
        public int Cpersona { get; set; }
        public string Dmotivo { get; set; }
        public DateTime Fhinicio { get; set; }
        public DateTime? Fhfin { get; set; }
        public int Gestado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
