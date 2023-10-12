using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ActasEclass
    {
        public int IdActas { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cfacultad { get; set; }
        public int? Cprograma { get; set; }
        public int? Ccarrera { get; set; }
        public string TituloArchivo { get; set; }
        public string TipoArchivo { get; set; }
        public string DescripcionArchivo { get; set; }
        public string Year { get; set; }
        public DateTime? Facta { get; set; }
        public int? Ctipoacta { get; set; }
        public byte[] Actas { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Cmodificacion { get; set; }
        public int? Estado { get; set; }
    }
}
