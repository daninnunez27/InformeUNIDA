using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TLogBaseSaldo
    {
        public int IdProceso { get; set; }
        public int? Calumno { get; set; }
        public DateTime? Fproceso { get; set; }
        public int? Cobligacion { get; set; }
        public int? Ccontenido { get; set; }
        public decimal? Nmonto { get; set; }
    }
}
