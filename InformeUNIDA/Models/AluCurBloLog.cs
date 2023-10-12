using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AluCurBloLog
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public int Ccurso { get; set; }
        public int CbloqueOrig { get; set; }
        public int CbloqueDest { get; set; }
        public string Gcruce { get; set; }
        public string Gnotas { get; set; }
        public string Gextraordinario { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public int? Coperacion { get; set; }
    }
}
