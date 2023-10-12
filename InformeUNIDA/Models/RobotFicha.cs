using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class RobotFicha
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public string Cingreso { get; set; }
        public int? Cpersona { get; set; }
        public string Dpersona { get; set; }
        public int? Ccarrera { get; set; }
        public string Dcarrera { get; set; }
        public short? Cmodalidad { get; set; }
        public string Dmodalidad { get; set; }
        public DateTime? Fproceso { get; set; }
        public string Gestado { get; set; }
    }
}
