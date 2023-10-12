using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AvisoPersona
    {
        public int Idaviso { get; set; }
        public int? Caviso { get; set; }
        public int? Cpersona { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? FLectura { get; set; }
        public string EstadoLectura { get; set; }
    }
}
