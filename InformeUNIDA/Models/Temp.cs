using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Temp
    {
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public int? Cbloque { get; set; }
        public int? Ccurso { get; set; }
        public int? Cprofesor { get; set; }
        public int? Ndia { get; set; }
        public DateTime? Hinicio { get; set; }
        public DateTime? Hfinal { get; set; }
    }
}
