using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TApPCro
    {
        public int Calumno { get; set; }
        public short Cperiodo { get; set; }
        public int? Cobligacion { get; set; }
        public int? Ccronograma { get; set; }
        public int Ncorr { get; set; }
    }
}
