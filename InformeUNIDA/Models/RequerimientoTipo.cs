using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class RequerimientoTipo
    {
        public int Gtipo { get; set; }
        public string Dtipo { get; set; }
        public int? Ccontenido { get; set; }
        public int? Gestado { get; set; }
    }
}
