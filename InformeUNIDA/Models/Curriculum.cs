using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Curriculum
    {
        public Curriculum()
        {
            AlumnoPeriodos = new HashSet<AlumnoPeriodo>();
            CurriculaCursos = new HashSet<CurriculaCurso>();
            PeriodoCurricula = new HashSet<PeriodoCurriculum>();
        }

        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Ccurricula { get; set; }
        public short Ccarrera { get; set; }
        public short Cespecialidad { get; set; }
        public string Dcurricula { get; set; }
        public string Scurricula { get; set; }
        public short Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Dobservacion { get; set; }
        public decimal? NnotaAprob { get; set; }
        public DateTime? Fdesde { get; set; }
        public int? CperiodoInicio { get; set; }

        public virtual ICollection<AlumnoPeriodo> AlumnoPeriodos { get; set; }
        public virtual ICollection<CurriculaCurso> CurriculaCursos { get; set; }
        public virtual ICollection<PeriodoCurriculum> PeriodoCurricula { get; set; }
    }
}
