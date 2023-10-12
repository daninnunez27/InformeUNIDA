﻿using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TTgcE
    {
        public short Ctabla { get; set; }
        public int Citem { get; set; }
        public string Ditem { get; set; }
        public string Sitem { get; set; }
        public short Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Gparametro { get; set; }
        public decimal? Nvalor { get; set; }
    }
}
