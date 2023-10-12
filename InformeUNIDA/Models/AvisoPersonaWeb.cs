using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AvisoPersonaWeb
    {
        public int Cpersona { get; set; }
        public int Caviso { get; set; }
        public int? Gestado { get; set; }
        public string Cmodificacio { get; set; }
    }
}
