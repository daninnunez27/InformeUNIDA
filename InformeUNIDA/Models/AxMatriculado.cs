using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AxMatriculado
    {
        public string Curso { get; set; }
        public int? Ccurso { get; set; }
        public string Turno { get; set; }
        public int? Matriculado { get; set; }
        public decimal? Ccarrera { get; set; }
        public string Carrera { get; set; }
    }
}
