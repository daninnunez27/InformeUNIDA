using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Tablad
    {
        public short? Ctabla { get; set; }
        public int? Citem { get; set; }
        public string Ditem { get; set; }
        public string Sitem { get; set; }
        public short? Gestado { get; set; }
        public string Cmodif { get; set; }
        public DateTime? Fmodif { get; set; }
        public short? Gpara { get; set; }
        public decimal? Nvalor { get; set; }
    }
}
