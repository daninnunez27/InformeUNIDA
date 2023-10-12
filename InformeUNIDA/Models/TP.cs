using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TP
    {
        public int Clocal { get; set; }
        public int Pabellon { get; set; }
        public string Dpabellon { get; set; }
        public string Spabellon { get; set; }
        public int Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
    }
}
