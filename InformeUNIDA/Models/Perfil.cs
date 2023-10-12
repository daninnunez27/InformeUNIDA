using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Perfil
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Ccarrera { get; set; }
        public short Cperfil { get; set; }
        public string Dperfil { get; set; }
        public string Sperfil { get; set; }
    }
}
