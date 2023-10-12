using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class MateriasHorario
    {
        public decimal IdMaterias { get; set; }
        public decimal? Ccurso { get; set; }
        public string Dcurso { get; set; }
        public string Scurso { get; set; }
        public string Dbloque { get; set; }
        public string Turno { get; set; }
        public decimal? Cmodalidad { get; set; }
        public decimal? Nciclo { get; set; }
        public decimal? Ndia { get; set; }
        public DateTime? Horainicio { get; set; }
        public DateTime? Horafin { get; set; }
        public decimal? Cprofesor { get; set; }
        public string Dpersona { get; set; }
        public decimal? Caula { get; set; }
        public string Daula { get; set; }
    }
}
