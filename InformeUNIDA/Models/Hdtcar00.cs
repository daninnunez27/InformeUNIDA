using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Hdtcar00
    {
        public DateTime Fmasum { get; set; }
        public string Cempre { get; set; }
        public string Ctpdoc { get; set; }
        public int Ndocum { get; set; }
        public string Cartic { get; set; }
        public int? Qartic { get; set; }
        public decimal Iartic { get; set; }
        public decimal Isaldo { get; set; }
        public decimal Imoras { get; set; }
        public decimal Igasto { get; set; }
    }
}
