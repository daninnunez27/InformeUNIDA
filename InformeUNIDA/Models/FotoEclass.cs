using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class FotoEclass
    {
        public int CfotoEclass { get; set; }
        public int? Cpersona { get; set; }
        public string Tfoto { get; set; }
        public byte[] FotoEclass1 { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Ccreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int Estado { get; set; }
    }
}
