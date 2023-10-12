using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CoincidenciasGen
    {
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public int? GtipoNota { get; set; }
        public DateTime? Fecha { get; set; }
        public int Generado { get; set; }
    }
}
