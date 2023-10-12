using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class IndIndicador
    {
        public short Cindicador { get; set; }
        public short Gtipo { get; set; }
        public string Dindicador { get; set; }
        public string Sindicador { get; set; }
        public string Gfrecuencia { get; set; }
        public short Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
    }
}
