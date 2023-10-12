using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TDato
    {
        public int Cdato { get; set; }
        public int? Cobjeto { get; set; }
        public int? Ccolumna { get; set; }
        public string Tdato1 { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
