using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ActaControl
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public int? Nacta { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
    }
}
