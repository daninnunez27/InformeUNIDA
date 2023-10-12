using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoPresenciaPosgrado
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Ccarrera { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public int Ccurricula { get; set; }
        public int Ccurso { get; set; }
        public DateTime? Finicio { get; set; }
        public DateTime? Ffinal { get; set; }
        public int? Gestado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
