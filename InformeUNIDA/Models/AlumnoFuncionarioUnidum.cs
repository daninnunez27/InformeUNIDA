using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoFuncionarioUnidum
    {
        public int? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public int? Cpersona { get; set; }
        public string Cingreso { get; set; }
        public short? Ccarrera { get; set; }
        public short? QcursosMax { get; set; }
    }
}
