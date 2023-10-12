using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class GrupoPersona
    {
        public short Cgrupo { get; set; }
        public string Dgrupo { get; set; }
        public string Sgrupo { get; set; }
        public string Ccategoria { get; set; }
        public string Cmora { get; set; }
        public string Cempresa { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short Gestado { get; set; }
    }
}
