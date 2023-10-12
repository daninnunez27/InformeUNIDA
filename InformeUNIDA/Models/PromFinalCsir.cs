using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PromFinalCsir
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short Ccarrera { get; set; }
        public short Nfamilia { get; set; }
        public short? Gseccion { get; set; }
        public decimal? NpromFinal { get; set; }
    }
}
