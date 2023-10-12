using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SumAvanceMatricula
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int CperiodoSum { get; set; }
        public DateTime Fmatricula { get; set; }
        public string CtipoAlumno { get; set; }
        public int Ccarrera { get; set; }
        public int Cespecialidad { get; set; }
        public int QmatriPago { get; set; }
        public int QmatriNoPago { get; set; }
        public int QmatriTotal { get; set; }
        public int QnomatriPago { get; set; }
        public int QnomatriNoPago { get; set; }
        public int QnomatriTotal { get; set; }
        public int QtotalPago { get; set; }
        public int QtotalNoPago { get; set; }
        public int Qasegurados { get; set; }
        public short Norden { get; set; }
    }
}
