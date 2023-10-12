using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class VCarreraModalidad
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public short Ccarrera { get; set; }
        public int Cmodalidad { get; set; }
        public string Scategoria { get; set; }
        public string Ncategoria { get; set; }
    }
}
