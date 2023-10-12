using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EstadisticaNotum
    {
        public int? Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public string Dcurso { get; set; }
        public string Dbloque { get; set; }
        public int? Calumno { get; set; }
        public int? FEstado { get; set; }
        public int? ApEstado { get; set; }
        public decimal? Nnota { get; set; }
        public int? GtipoNota { get; set; }
        public string Ditem { get; set; }
        public int? Nmatriculado { get; set; }
    }
}
