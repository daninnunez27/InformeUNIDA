using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CostosCurblocar
    {
        public int Nano { get; set; }
        public int Nmes { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public int Ccarrera { get; set; }
        public int? CantidadAlumnos { get; set; }
        public int? CantidadSesiones { get; set; }
    }
}
