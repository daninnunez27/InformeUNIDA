using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CoincidenciasAveTemp
    {
        public decimal Calumno { get; set; }
        public int Cperiodo { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public int GtipoNota { get; set; }
        public DateTime Fexamen { get; set; }
        public DateTime? Hexamen { get; set; }
        public DateTime? Fexamenave { get; set; }
        public int? CprofesorRegistro { get; set; }
    }
}
