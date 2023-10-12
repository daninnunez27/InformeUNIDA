using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoProceso
    {
        public short Cempresa { get; set; }
        public short Csolicitud { get; set; }
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Calumno { get; set; }
        public short? Gestado { get; set; }
    }
}
