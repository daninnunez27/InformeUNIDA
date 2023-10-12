using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TPpd
    {
        public int Calumno { get; set; }
        public short Cperiodo { get; set; }
        public string Cingreso { get; set; }
        public short Ccurso { get; set; }
        public string Scurso { get; set; }
        public string Dcurso { get; set; }
        public string Dpersona { get; set; }
        public string Scarrera { get; set; }
        public int? Pf1 { get; set; }
        public int? Pf2 { get; set; }
        public int? Pe { get; set; }
        public int NmateriaNormal { get; set; }
    }
}
