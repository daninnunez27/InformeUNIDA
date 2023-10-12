using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AreaAcademica
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Cdepartamento { get; set; }
        public int Carea { get; set; }
        public string Darea { get; set; }
        public string Sarea { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
