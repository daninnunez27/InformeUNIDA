using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaDeslaboral
    {
        public int Claboral { get; set; }
        public int Cencuesta { get; set; }
        public string Dempresa { get; set; }
        public int? Tempresa { get; set; }
        public string Tdireccion { get; set; }
        public int? Ndireccion { get; set; }
        public string Tciudad { get; set; }
        public string Tdepartamento { get; set; }
        public string Ntelefono { get; set; }
        public string Tcorreo { get; set; }

        public virtual EncuestaEgresado1 CencuestaNavigation { get; set; }
    }
}
