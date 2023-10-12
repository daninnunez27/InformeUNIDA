using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class FichaMoodle
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public int? CategoriaCd { get; set; }
        public string CategoriaNombre { get; set; }
        public string CursoNombreCorto { get; set; }
        public string CursoNombreLargo { get; set; }
        public DateTime? FechaCreacionMoodle { get; set; }
        public DateTime? FechaModificacionMoodle { get; set; }
    }
}
