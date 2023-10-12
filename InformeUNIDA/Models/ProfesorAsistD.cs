using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfesorAsistD
    {
        public int IdProfesorAsistD { get; set; }
        public int IdProfesorAsist { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public int? Caula { get; set; }
        public int? Cprofesor { get; set; }
        public DateTime? Hinicio { get; set; }
        public DateTime? Hfinal { get; set; }
        public int? Ndia { get; set; }
        public DateTime? Fdesde { get; set; }
        public DateTime? Fhasta { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
    }
}
