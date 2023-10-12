using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoAsisteEvaluacionH
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public int Ccurso { get; set; }
        public int GtipoNota { get; set; }
        public DateTime Fasistencia { get; set; }
        public int Cbloque { get; set; }
        public int Nfalta { get; set; }
        public int Njustifica { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Clog { get; set; }
    }
}
