using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoReclamoD
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Cevento { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public int Calumno { get; set; }
        public DateTime? Freclamo { get; set; }
        public short? SdevolucionProf { get; set; }
        public DateTime? FdevolucionProf { get; set; }
        public short? SrecojoAlumno { get; set; }
        public DateTime? FrecojoAlumno { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
