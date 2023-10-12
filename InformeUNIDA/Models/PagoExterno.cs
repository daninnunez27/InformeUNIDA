using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PagoExterno
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Ccarrera { get; set; }
        public string Dpersona { get; set; }
        public decimal? Pagorealizado { get; set; }
        public string Observacion { get; set; }
    }
}
