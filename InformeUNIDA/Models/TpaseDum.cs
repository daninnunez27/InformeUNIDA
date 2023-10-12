using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TpaseDum
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cdepartamento { get; set; }
        public string Ddepartamento { get; set; }
        public string Sdepartamento { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
