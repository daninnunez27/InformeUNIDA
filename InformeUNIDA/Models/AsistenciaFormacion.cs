using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AsistenciaFormacion
    {
        public int Cprofesor { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hformacion { get; set; }
        public DateTime? Fhmarca { get; set; }
    }
}
