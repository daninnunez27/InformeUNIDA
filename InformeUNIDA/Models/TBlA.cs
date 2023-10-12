using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TBlA
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public int Cbloque { get; set; }
        public string Dbloque { get; set; }
        public int? Ccarrera { get; set; }
        public int Nciclo { get; set; }
        public int Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public int Ccurricula { get; set; }
    }
}
