using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Marcaciones2
    {
        public string Cod { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Cprofesor { get; set; }
        public int Cid { get; set; }
        public string Tbarra { get; set; }
        public string Scurso { get; set; }
        public string Saccion { get; set; }
        public int? Ccurso { get; set; }
        public int? IdProfesorAsistProcesado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
    }
}
