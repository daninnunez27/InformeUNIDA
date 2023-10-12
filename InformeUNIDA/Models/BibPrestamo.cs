using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BibPrestamo
    {
        public int Cprestamo { get; set; }
        public int? Cmovimiento { get; set; }
        public DateTime? Fhinicio { get; set; }
        public DateTime? Fhfin { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual BibMovimiento CmovimientoNavigation { get; set; }
    }
}
