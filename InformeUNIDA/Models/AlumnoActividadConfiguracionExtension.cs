using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoActividadConfiguracionExtension
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Cprofesor { get; set; }
        public short Ccurso { get; set; }
        public short Cbloque { get; set; }
        public int? NnotaActividad1 { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
