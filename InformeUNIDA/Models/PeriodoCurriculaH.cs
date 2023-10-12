using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PeriodoCurriculaH
    {
        public short Cperiodo { get; set; }
        public short Ccurricula { get; set; }
        public short Ccarrera { get; set; }
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public short? Chorario { get; set; }
    }
}
