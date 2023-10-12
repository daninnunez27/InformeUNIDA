using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Materium
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Ccarrera { get; set; }
        public short Cgrupo { get; set; }
        public short Cmateria { get; set; }
        public string Dmateria { get; set; }
        public string Smateria { get; set; }
    }
}
