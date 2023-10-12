using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TBloqueCursoRegistroEv
    {
        public int Cregistro { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public int GtipoNota { get; set; }
        public int? CprofesorRegistro { get; set; }
        public DateTime? Fexamen { get; set; }
        public DateTime? FdigitaDesde { get; set; }
        public DateTime? FdigitaHasta { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
