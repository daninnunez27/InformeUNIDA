using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LectoraT
    {
        public int Choja { get; set; }
        public short NchequeoHoja { get; set; }
        public string Observa { get; set; }
        public string Ndigito1 { get; set; }
        public string Ndigito2 { get; set; }
        public short Snota { get; set; }
        public short Nverifica { get; set; }
        public short NchequeoVerifica { get; set; }
        public short Nlectura { get; set; }
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public string Tdato { get; set; }
        public short Ngrupo { get; set; }
    }
}
