using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class VUsuario
    {
        public string Tipo { get; set; }
        public string Usuario { get; set; }
        public int CodigoAluProf { get; set; }
        public string Tcorreo { get; set; }
    }
}
