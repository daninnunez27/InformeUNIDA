using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BibMovimiento
    {
        public BibMovimiento()
        {
            BibPrestamos = new HashSet<BibPrestamo>();
        }

        public int Cmovimiento { get; set; }
        public int? Cpersona { get; set; }
        public int? Cobjeto { get; set; }
        public int? Gtipo { get; set; }
        public DateTime? Fhestado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual Objeto CobjetoNavigation { get; set; }
        public virtual ICollection<BibPrestamo> BibPrestamos { get; set; }
    }
}
