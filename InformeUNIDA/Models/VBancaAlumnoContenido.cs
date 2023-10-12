using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class VBancaAlumnoContenido
    {
        public string Cingreso { get; set; }
        public short Cperiodo { get; set; }
        public string Speriodo { get; set; }
        public string Dpersona { get; set; }
        public int Ccontenido { get; set; }
        public short Gcondicion { get; set; }
        public short Gestado { get; set; }
        public decimal? FNmontoBaseSaldoCalc { get; set; }
        public string ApScondicion { get; set; }
        public string ApSestado { get; set; }
    }
}
