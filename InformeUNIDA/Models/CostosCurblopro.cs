using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CostosCurblopro
    {
        public int Nano { get; set; }
        public int Nmes { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public int Cprofesor { get; set; }
        public int? TotproCurblo { get; set; }
        public string Cempre { get; set; }
        public int? Cpersona { get; set; }
        public string Ctraba { get; set; }
    }
}
