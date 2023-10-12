using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ExploPuntaje
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Cevaluacion { get; set; }
        public int Cpersona { get; set; }
        public short Cfamilia { get; set; }
        public decimal? Npuntaje { get; set; }
        public int? Ccurso { get; set; }
    }
}
