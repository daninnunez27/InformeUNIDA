using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CostosAulse
    {
        public int Nano { get; set; }
        public int Nmes { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public int Caula { get; set; }
        public int Ccarrera { get; set; }
        public int Canses { get; set; }
        public int? Alumnos { get; set; }
        public int? Participacion { get; set; }
    }
}
