using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TpaseAdmi
    {
        public short Cadmision { get; set; }
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Gmodalidad { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Dadmision { get; set; }
        public string Sadmision { get; set; }
        public short? Naprobado { get; set; }
        public short? NminExamenes { get; set; }
        public short? NmaxExamenes { get; set; }
        public DateTime? FminExamen { get; set; }
        public short? GtipoCalculo { get; set; }
        public short? Cperiodo2 { get; set; }
        public int? Cactividad { get; set; }
        public short? IgeneraFichaMatricula { get; set; }
    }
}
