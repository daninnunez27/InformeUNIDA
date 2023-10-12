using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Actividad
    {
        public short Cactividad { get; set; }
        public short CtipoActividad { get; set; }
        public string Dactividad { get; set; }
        public string Sactividad { get; set; }
        public DateTime Factividad { get; set; }
        public short Gestado { get; set; }
        public short? Caplicacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Cevento { get; set; }
        public string GrequierePostul { get; set; }
        public string GrequiereTaller { get; set; }
        public string GcitaDecano { get; set; }
    }
}
