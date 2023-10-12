using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PeriodoRangosTipoNotum
    {
        public int Cperiodo { get; set; }
        public short GtipoNota { get; set; }
        public DateTime Fdesde { get; set; }
        public DateTime Fhasta { get; set; }
        public short GtipoNotaEx { get; set; }
    }
}
