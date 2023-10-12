using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TBF
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public int? Cantidad { get; set; }
    }
}
