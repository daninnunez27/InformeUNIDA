using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfesorVirtual
    {
        public short Cperiodo { get; set; }
        public string Speriodo { get; set; }
        public int Cprofesor { get; set; }
        public int Cpersona { get; set; }
        public string Dpersona { get; set; }
        public string TclaveSil { get; set; }
        public int? Ccurso { get; set; }
        public string Scurso { get; set; }
        public string Dcurso { get; set; }
        public int? Cbloque { get; set; }
        public string Dbloque { get; set; }
    }
}
