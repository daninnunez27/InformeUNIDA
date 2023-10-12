using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class DocumentoVersion
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cdocumento { get; set; }
        public short Nversion { get; set; }
        public string Tversion { get; set; }
        public string Ttexto { get; set; }
        public decimal? Nsuperior { get; set; }
        public decimal? Ninferior { get; set; }
        public decimal? Nizquierdo { get; set; }
        public decimal? Nderecho { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
