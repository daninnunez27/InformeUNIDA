using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TH
    {
        public short Chorario { get; set; }
        public short Ndia { get; set; }
        public DateTime Hinicio { get; set; }
        public DateTime Hfinal { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
