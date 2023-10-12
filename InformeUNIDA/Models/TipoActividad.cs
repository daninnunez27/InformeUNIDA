using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TipoActividad
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short CtipoActividad { get; set; }
        public string DtipoActividad { get; set; }
        public string StipoActividad { get; set; }
        public short Gestado { get; set; }
        public string Gnaturaleza { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
