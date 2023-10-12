using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class MatriculaControl
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short? NcursosLim { get; set; }
        public short? NcreditosLim { get; set; }
        public short Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
