using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PlanillaTexto
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Nplanilla { get; set; }
        public short Nvez { get; set; }
        public string Dglosa { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Femision { get; set; }
    }
}
