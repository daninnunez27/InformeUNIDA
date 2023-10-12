using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class DocumCompanium
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public short? Ccompania { get; set; }
        public short? Norden { get; set; }
        public short? Gentrego { get; set; }
        public DateTime? Fentrego { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
