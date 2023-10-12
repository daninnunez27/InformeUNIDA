using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SigValoresIndex
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Cindice { get; set; }
        public DateTime Findice { get; set; }
        public string Gvariacion { get; set; }
        public decimal Nvalor { get; set; }
    }
}
