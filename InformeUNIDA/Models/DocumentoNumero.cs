using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class DocumentoNumero
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cdocumento { get; set; }
        public short Nano { get; set; }
        public short Nnumero { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
