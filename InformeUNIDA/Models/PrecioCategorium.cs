using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PrecioCategorium
    {
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public int? Ccarrera { get; set; }
        public int? Gcategoria { get; set; }
        public decimal? NimpCuota { get; set; }
    }
}
