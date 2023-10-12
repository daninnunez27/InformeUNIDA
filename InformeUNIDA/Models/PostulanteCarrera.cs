using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PostulanteCarrera
    {
        public int Cadmision { get; set; }
        public int Cpersona { get; set; }
        public int Ccarrera { get; set; }
        public int? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
