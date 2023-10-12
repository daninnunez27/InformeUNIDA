using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LibroRecomendadoDocente
    {
        public int? Cinstitucion { get; set; }
        public int? Ccurso { get; set; }
        public int? Cprofesor { get; set; }
        public int? Cprograma { get; set; }
        public string Dclasificacion { get; set; }
        public string Tdato { get; set; }
        public int Libroid { get; set; }
    }
}
