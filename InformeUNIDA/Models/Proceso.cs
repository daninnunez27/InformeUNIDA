using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Proceso
    {
        public int Cproceso { get; set; }
        public string Dproceso { get; set; }
        public int? Icompleto { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
