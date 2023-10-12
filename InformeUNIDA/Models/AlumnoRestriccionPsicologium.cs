using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoRestriccionPsicologium
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public string Dglosa { get; set; }
        public short Gcaso { get; set; }
        public string SusuarioAut { get; set; }
    }
}
