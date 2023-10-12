using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Exploratorio
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Cpersona { get; set; }
        public int? Cingles { get; set; }
        public int? Cmatema { get; set; }
        public int? Cmatemb { get; set; }
        public int? Clenguaje { get; set; }
        public int? Cfisica { get; set; }
        public string Sprocesa { get; set; }
    }
}
