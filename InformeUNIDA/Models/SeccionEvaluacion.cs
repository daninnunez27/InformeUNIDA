using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SeccionEvaluacion
    {
        public short Carea { get; set; }
        public short Cseccion { get; set; }
        public string Dseccion { get; set; }
        public string Sseccion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
