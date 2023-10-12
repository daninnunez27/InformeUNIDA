using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CurriculaAdd
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Ccurricula { get; set; }
        public short Ccarrera { get; set; }
        public short Cespecialidad { get; set; }
        public string Dcurricula { get; set; }
        public string Scurricula { get; set; }
        public int Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Dobservacion { get; set; }
        public int NnotaAprob { get; set; }
        public int Ncorrelativo { get; set; }
    }
}
