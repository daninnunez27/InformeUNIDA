using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PerfilProfesor
    {
        public int Cperfil { get; set; }
        public short? Cprograma { get; set; }
        public short? Cprofesor { get; set; }
        public string Dperfil { get; set; }
        public short? Cperiodo { get; set; }
        public int? Estado { get; set; }
    }
}
