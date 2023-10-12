using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Alertum
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public short Calerta { get; set; }
        public short Nsecuencia { get; set; }
        public string Dgrupo { get; set; }
        public string Dsubgrupo { get; set; }
        public string Dalerta { get; set; }
        public short Gestado { get; set; }
        public double? Gparametro1 { get; set; }
        public double? Gparametro2 { get; set; }
        public short Nprioridad { get; set; }
        public string Ddetallado { get; set; }
    }
}
