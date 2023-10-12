using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ActaParaAcad
    {
        public int Nacta { get; set; }
        public short Gcategoria { get; set; }
        public short Gestado { get; set; }
        public DateTime Fapertura { get; set; }
        public DateTime? Fcierre { get; set; }
    }
}
