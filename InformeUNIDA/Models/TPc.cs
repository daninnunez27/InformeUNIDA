using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TPc
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public int? Ccarrera { get; set; }
        public int? Ccurricula { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public int Chorario { get; set; }
        public int Gdefault { get; set; }
        public int? CperiodoAnt { get; set; }
        public int? CcurriculaAnt { get; set; }
        public int? Cespecialidad { get; set; }
    }
}
