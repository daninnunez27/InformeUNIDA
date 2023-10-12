using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Resolucion
    {
        public int Nresolucion { get; set; }
        public string Dresolucion { get; set; }
        public DateTime Fresolucion { get; set; }
        public int Cperiodo { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
