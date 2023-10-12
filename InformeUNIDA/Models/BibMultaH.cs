using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BibMultaH
    {
        public int Cmulta { get; set; }
        public int? Cpersona { get; set; }
        public int? GtipoUsuario { get; set; }
        public int? Cobjeto { get; set; }
        public decimal? Nmonto { get; set; }
        public int? Ccomprobante { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Clog { get; set; }
        public int IdCreacion { get; set; }
    }
}
