using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaVProductoDetalle
    {
        public int Cproducto { get; set; }
        public string Dproducto { get; set; }
        public int Ccontenido { get; set; }
        public string Dcontenido { get; set; }
        public int Nsecuencia { get; set; }
        public int Cconcepto { get; set; }
        public string Dconcepto { get; set; }
    }
}
