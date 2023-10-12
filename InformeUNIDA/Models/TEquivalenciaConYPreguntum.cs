using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TEquivalenciaConYPreguntum
    {
        public short? Ccurso { get; set; }
        public short? CcursoEquiv { get; set; }
        public int Gequivalencia { get; set; }
        public int Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public int Dato { get; set; }
        public string Grupo { get; set; }
        public string Disciplina { get; set; }
        public string Asociado { get; set; }
    }
}
