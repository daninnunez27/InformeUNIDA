using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CostosTransaccionC
    {
        public int Nano { get; set; }
        public int Nmes { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Ccarrera { get; set; }
        public int? CantidadAlumnos { get; set; }
    }
}
