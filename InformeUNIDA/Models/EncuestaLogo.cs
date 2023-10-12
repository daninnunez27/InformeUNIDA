using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaLogo
    {
        public int IdEncuesta { get; set; }
        public int? Calumno { get; set; }
        public int? Cingreso { get; set; }
        public int? Cperiodo { get; set; }
        public int? Cpersona { get; set; }
        public int? Logo1 { get; set; }
        public int? Logo2 { get; set; }
        public int? Logo3 { get; set; }
        public int? Logo4 { get; set; }
        public int? Logo5 { get; set; }
        public int? Logo6 { get; set; }
        public int? Logo7 { get; set; }
        public int? Logo8 { get; set; }
        public int? Ciclo { get; set; }
        public string Corte { get; set; }
        public string Talla { get; set; }
        public string Comentario { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
