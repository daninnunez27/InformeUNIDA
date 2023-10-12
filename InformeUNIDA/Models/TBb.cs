using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TBb
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Cbloque { get; set; }
        public string Dbloque { get; set; }
        public short? Ccarrera { get; set; }
        public short? Nciclo { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Ccurricula { get; set; }
    }
}
