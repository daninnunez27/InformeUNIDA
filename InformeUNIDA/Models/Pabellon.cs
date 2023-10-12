using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Pabellon
    {
        public short Clocal { get; set; }
        public int Cpabellon { get; set; }
        public string Dpabellon { get; set; }
        public string Spabellon { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
