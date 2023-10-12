using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BloqueCursoAlumnoMoodle
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Cbloque { get; set; }
        public short Ccurso { get; set; }
        public int Calumno { get; set; }
        public int? AlumnoId { get; set; }
        public string Link { get; set; }
        public DateTime? FechaCreacionMoodle { get; set; }
        public DateTime? FechaModificacionMoodle { get; set; }
        public string AlumnoCursoEstado { get; set; }
        public string AlumnoEstado { get; set; }
    }
}
