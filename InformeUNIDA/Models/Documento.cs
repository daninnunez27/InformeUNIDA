using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Documento
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cdocumento { get; set; }
        public string Ddocumento { get; set; }
        public short? Gpago { get; set; }
        public string Cartic { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
