using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PlanillaEquivale
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short GtipoAsistencia { get; set; }
        public short GtipoHora { get; set; }
        public string Sequivalencia { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
