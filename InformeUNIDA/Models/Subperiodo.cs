using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Subperiodo
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Csubperiodo { get; set; }
        public string Ssubperiodo { get; set; }
        public DateTime Finicio { get; set; }
        public DateTime Ffinal { get; set; }
        public short Nsemana { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
