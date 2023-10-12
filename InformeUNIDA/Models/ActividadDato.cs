using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ActividadDato
    {
        public short CtipoActividad { get; set; }
        public short Cdato { get; set; }
        public short Norden { get; set; }
        public string Ddato { get; set; }
        public string Sdato { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
