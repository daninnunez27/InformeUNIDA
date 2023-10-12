using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoActividad
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short Ccurso { get; set; }
        public short GtipoNota { get; set; }
        public int? NnotaActividad1 { get; set; }
        public int? NnotaActividad2 { get; set; }
        public int? NnotaActividad3 { get; set; }
        public int? NnotaActividad4 { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
