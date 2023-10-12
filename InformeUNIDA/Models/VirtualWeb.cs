using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class VirtualWeb
    {
        public string Usuario { get; set; }
        public DateTime? Inicio { get; set; }
        public DateTime? Fin { get; set; }
        public string HorasConectadas { get; set; }
        public int? Min { get; set; }
        public string Servidor { get; set; }
        public string Url { get; set; }
    }
}
