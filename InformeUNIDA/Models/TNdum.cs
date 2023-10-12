using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TNdum
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public short? Ccurso { get; set; }
        public int? GtipoNota { get; set; }
        public string Nnota { get; set; }
        public int Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public int? Tnota { get; set; }
        public int Data { get; set; }
        public string Aluno { get; set; }
        public string Disciplina { get; set; }
        public string Prova { get; set; }
    }
}
