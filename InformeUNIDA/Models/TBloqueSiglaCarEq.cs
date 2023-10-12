using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TBloqueSiglaCarEq
    {
        public short? Cperiodo { get; set; }
        public string Corto { get; set; }
        public int? MinCcarrera { get; set; }
        public int? MaxCcarrera { get; set; }
        public int? Cantidad { get; set; }
    }
}
