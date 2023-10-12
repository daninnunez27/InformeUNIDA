using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SumMonitoreoD
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Cpersona { get; set; }
        public int? Cusuario { get; set; }
        public int? Cprofesor { get; set; }
        public int? Ccurso { get; set; }
        public int? Cdepartamento { get; set; }
        public int? Carea { get; set; }
        public int? CcargoCoordina { get; set; }
        public int? CcargoDecano { get; set; }
        public decimal? NperSes { get; set; }
        public decimal? NperMin { get; set; }
        public decimal NprogSes { get; set; }
        public decimal NprogMin { get; set; }
        public decimal NprogCur { get; set; }
        public decimal NprogProf { get; set; }
        public decimal NtardSes { get; set; }
        public decimal NtardMin { get; set; }
        public decimal NtardCur { get; set; }
        public decimal NtardProf { get; set; }
        public decimal NfalSes { get; set; }
        public decimal NfalCur { get; set; }
        public decimal NfalProf { get; set; }
        public decimal NrecSes { get; set; }
        public decimal NrecCurcomp { get; set; }
        public decimal NrecCurincomp { get; set; }
        public decimal NrecProfcomp { get; set; }
        public decimal NrecProfincomp { get; set; }
        public decimal NsesOtros { get; set; }
    }
}
