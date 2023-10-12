using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfesorTema
    {
        public int? Cperiodo { get; set; }
        public int? Cprofesor { get; set; }
        public int? Cpersona { get; set; }
        public int? Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public short? Ndia { get; set; }
        public string Dglosa { get; set; }
        public DateTime? Fasistencia { get; set; }
    }
}
