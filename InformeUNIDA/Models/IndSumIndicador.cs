using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class IndSumIndicador
    {
        public short Cunidad { get; set; }
        public short Cindicador { get; set; }
        public string Dperiodo { get; set; }
        public string Dglosa { get; set; }
        public short Nsecuencia { get; set; }
        public decimal Nvalor { get; set; }
    }
}
