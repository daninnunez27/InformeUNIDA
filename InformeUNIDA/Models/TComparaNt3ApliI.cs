using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TComparaNt3ApliI
    {
        public int Calumno { get; set; }
        public short Cperiodo { get; set; }
        public short Ccurso { get; set; }
        public decimal? Npromedio { get; set; }
        public int NpromedioCal { get; set; }
        public short? Gaprobado { get; set; }
        public int GaprobadoCal { get; set; }
        public string Tcambio { get; set; }
    }
}
