using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AutorizaExaman
    {
        public short Ncaso { get; set; }
        public short Gcategoria { get; set; }
        public short GdeudaVencida { get; set; }
        public short Gavance { get; set; }
        public short Granking { get; set; }
        public decimal PminimoPago { get; set; }
    }
}
