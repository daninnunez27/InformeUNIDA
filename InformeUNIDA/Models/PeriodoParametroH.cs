using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PeriodoParametroH
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Nparametro { get; set; }
        public short? Gestado { get; set; }
        public int? Nnumero { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Nnumero2 { get; set; }
        public int? Clog { get; set; }
    }
}
