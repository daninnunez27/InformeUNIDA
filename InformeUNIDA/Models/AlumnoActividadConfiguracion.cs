using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoActividadConfiguracion
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Cprofesor { get; set; }
        public short Ccurso { get; set; }
        public short Cbloque { get; set; }
        public short GtipoNota { get; set; }
        public int? NnotaActividad1 { get; set; }
        public int? NnotaActividad2 { get; set; }
        public int? NnotaActividad3 { get; set; }
        public int? NnotaActividad4 { get; set; }
        public int? NnotaActividad5 { get; set; }
        public int? NnotaActividad6 { get; set; }
        public int? NnotaActividad7 { get; set; }
        public int? NnotaActividad8 { get; set; }
        public int? NnotaActividad9 { get; set; }
        public int? NnotaActividad10 { get; set; }
        public int? NnotaActividad11 { get; set; }
        public int? NnotaActividad12 { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
