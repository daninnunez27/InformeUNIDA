using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TpaseAa
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cdepartamento { get; set; }
        public short Carea { get; set; }
        public string Darea { get; set; }
        public string Sarea { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
