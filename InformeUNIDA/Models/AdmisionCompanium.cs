using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AdmisionCompanium
    {
        public short Cadmision { get; set; }
        public short Ccompania { get; set; }
        public string Dcompania { get; set; }
        public string Scompania { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
