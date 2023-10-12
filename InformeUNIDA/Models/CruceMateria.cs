using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CruceMateria
    {
        public decimal? Calumno { get; set; }
        public decimal? Ccurso { get; set; }
        public decimal? Cbloque { get; set; }
        public decimal? Nciclo { get; set; }
        public decimal? Ndia { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
    }
}
