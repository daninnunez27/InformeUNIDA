using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ControlOpcion
    {
        public int Cusuario { get; set; }
        public int Cmodulo { get; set; }
        public DateTime Fregistro { get; set; }
        public string Tobjeto { get; set; }
    }
}
