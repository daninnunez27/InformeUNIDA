using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LogFichado
    {
        public int? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public int? Ccurricula { get; set; }
        public int? Ccurso { get; set; }
        public string Dglosa { get; set; }
        public DateTime? Fproceso { get; set; }
    }
}
