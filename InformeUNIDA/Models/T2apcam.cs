using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class T2apcam
    {
        public int Calumno { get; set; }
        public short Cperiodo { get; set; }
        public short Ccarrera { get; set; }
        public int? Ccarrera2 { get; set; }
        public int Cmodalidad { get; set; }
        public int? Cmodalidad2 { get; set; }
        public short? Ccurricula { get; set; }
        public int? Ccurricula2 { get; set; }
    }
}
