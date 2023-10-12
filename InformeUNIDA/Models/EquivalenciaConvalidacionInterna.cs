using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EquivalenciaConvalidacionInterna
    {
        public int Calumno { get; set; }
        public short Ccurso { get; set; }
        public short CcursoEquiv { get; set; }
        public int? CalumnoEquiv { get; set; }
        public short? CperiodoEquiv { get; set; }
        public short? Gequivalencia { get; set; }
        public short? Gestado { get; set; }
        public decimal? Npromedio { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int Cequivalencia { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
    }
}
