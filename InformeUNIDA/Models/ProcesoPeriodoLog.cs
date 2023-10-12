using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProcesoPeriodoLog
    {
        public int Idcreacion { get; set; }
        public int? Cproceso { get; set; }
        public DateTime? Fcreacion { get; set; }
        public int? Calumno { get; set; }
        public int? Cperiodo { get; set; }
        public string Tlog { get; set; }
        public string Tobservacion { get; set; }
    }
}
