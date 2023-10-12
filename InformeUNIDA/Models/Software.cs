using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Software
    {
        public int Csoftware { get; set; }
        public string Dsoftware { get; set; }
        public string Ssoftware { get; set; }
        public string Tversion { get; set; }
        public int? Gfabricante { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
