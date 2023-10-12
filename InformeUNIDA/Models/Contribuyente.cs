using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Contribuyente
    {
        public int Ccontribuyente { get; set; }
        public string Tsolicitante { get; set; }
        public string Truc { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
