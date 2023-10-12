using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TurnoSpu
    {
        public int Cadmision { get; set; }
        public short Nturno { get; set; }
        public DateTime Finicio { get; set; }
        public DateTime Ffinal { get; set; }
        public short QturnosMax { get; set; }
    }
}
