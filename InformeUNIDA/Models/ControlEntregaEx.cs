using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ControlEntregaEx
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Cevento { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public int Cprofesor { get; set; }
        public DateTime? FentregaProf { get; set; }
        public DateTime? FDevolProf { get; set; }
        public DateTime? FDevolReal { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
