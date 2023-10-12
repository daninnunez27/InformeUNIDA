using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class DocumentoWeb
    {
        public int CdocumentoWeb { get; set; }
        public string CtipoDocumento { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Ccarrera { get; set; }
        public string CtipoDestino { get; set; }
        public string Tdocumento { get; set; }
        public string Druta { get; set; }
        public string Dsumilla { get; set; }
        public int? Nprioridad { get; set; }
        public DateTime? Fdesde { get; set; }
        public DateTime? Fhasta { get; set; }
        public int? Gseccion { get; set; }
    }
}
