using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TDeedu
    {
        public string Deducativo { get; set; }
        public int? Cantidad { get; set; }
        public int Ncorrelativo { get; set; }
        public int? Ceducativo { get; set; }
    }
}
