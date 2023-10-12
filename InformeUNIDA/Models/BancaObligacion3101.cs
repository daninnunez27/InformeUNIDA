using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaObligacion3101
    {
        public int Cobligacion { get; set; }
        public int Calumno { get; set; }
        public short Cperiodo { get; set; }
        public string Sestado { get; set; }
        public int Nsecuencia { get; set; }
        public string Stipo { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cpersona { get; set; }
        public string Cingreso { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
