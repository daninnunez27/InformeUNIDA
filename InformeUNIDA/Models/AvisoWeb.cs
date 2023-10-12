using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AvisoWeb
    {
        public int Caviso { get; set; }
        public string Daviso { get; set; }
        public int? Gestado { get; set; }
        public int? Gtipo { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
    }
}
