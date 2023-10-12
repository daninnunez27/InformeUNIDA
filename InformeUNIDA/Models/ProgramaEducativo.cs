using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProgramaEducativo
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Ceducativo { get; set; }
        public string Scategoria { get; set; }
        public short Gcategoria { get; set; }
    }
}
