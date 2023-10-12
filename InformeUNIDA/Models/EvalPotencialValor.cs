using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EvalPotencialValor
    {
        public short? GtipoExamen { get; set; }
        public string Cgrupo { get; set; }
        public string Gsexo { get; set; }
        public int? Ninicio { get; set; }
        public int? Nfinal { get; set; }
        public int? Nvalor { get; set; }
    }
}
