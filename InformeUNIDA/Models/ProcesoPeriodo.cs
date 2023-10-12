using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProcesoPeriodo
    {
        public int Cpaso { get; set; }
        public int? Cproceso { get; set; }
        public int? Cperiodo { get; set; }
        public DateTime? Fdesde { get; set; }
        public DateTime? Fhasta { get; set; }
    }
}
