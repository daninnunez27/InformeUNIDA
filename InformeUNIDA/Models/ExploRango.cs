using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ExploRango
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Cevaluacion { get; set; }
        public short Cfamilia { get; set; }
        public short Norden { get; set; }
        public short NpregDesde { get; set; }
        public short NpregHasta { get; set; }
    }
}
