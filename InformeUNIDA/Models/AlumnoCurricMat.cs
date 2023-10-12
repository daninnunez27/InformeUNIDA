using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoCurricMat
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Calumno { get; set; }
        public short Ccarrera { get; set; }
        public short Ccurriculum { get; set; }
        public short Cgrupo { get; set; }
        public short Cmateria { get; set; }
        public short Gnivel { get; set; }
    }
}
