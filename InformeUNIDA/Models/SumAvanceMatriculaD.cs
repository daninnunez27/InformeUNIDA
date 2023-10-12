using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SumAvanceMatriculaD
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int CperiodoSum { get; set; }
        public int Ccarrera { get; set; }
        public short? Cmodalidad { get; set; }
        public short? Cespecialidad { get; set; }
        public string Cingreso { get; set; }
        public string Ctpalu { get; set; }
        public short Gcondicion { get; set; }
        public string Gpago { get; set; }
        public int Calumno { get; set; }
        public int Cpersona { get; set; }
        public int? Cadmision { get; set; }
        public string Grecuperado { get; set; }
    }
}
