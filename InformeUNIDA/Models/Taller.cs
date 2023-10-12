using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Taller
    {
        public short Cevento { get; set; }
        public short Ctaller { get; set; }
        public string Dtaller { get; set; }
        public string Dexpositor { get; set; }
        public string Staller { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
