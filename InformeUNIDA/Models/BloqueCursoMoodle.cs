using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BloqueCursoMoodle
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Cbloque { get; set; }
        public short Ccurso { get; set; }
        public int? CursoId { get; set; }
        public int? CategoriaCod { get; set; }
        public string CategoriaNombre { get; set; }
        public string CursoNombreCorto { get; set; }
        public string CursoNombreLargo { get; set; }
        public string Link { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaCreacionMoodle { get; set; }
        public DateTime? FechaModificacionMoodle { get; set; }
    }
}
