using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AreaEvaluacion
    {
        public short Carea { get; set; }
        public string Darea { get; set; }
        public string Sarea { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
