using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Marcacionesfoto
    {
        public int Cid { get; set; }
        public byte[] Tfoto { get; set; }
        public int? Pcnumero { get; set; }
        public int? Estado { get; set; }
        public int? Cinstitucion { get; set; }
    }
}
