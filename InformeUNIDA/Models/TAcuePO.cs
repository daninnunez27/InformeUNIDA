using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TAcuePO
    {
        public int? Cobligacion { get; set; }
        public int? Calumno { get; set; }
        public int? Cperiodo { get; set; }
        public string Sestado { get; set; }
        public int? Nsecuencia { get; set; }
        public string Stipo { get; set; }
        public int Ncorre { get; set; }
    }
}
