using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TFigAp
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public string Cingreso { get; set; }
        public int Cpersona { get; set; }
        public short Ccarrera { get; set; }
        public int Cmodalidad { get; set; }
        public short? QcursosMat { get; set; }
        public short? QcrediMat { get; set; }
        public short Gcondicion { get; set; }
        public short Gestado { get; set; }
    }
}
