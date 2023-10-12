using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfesorIngresoEgreso
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cprofesor { get; set; }
        public int Cpersona { get; set; }
        public string Gtipo { get; set; }
        public int Nregistro { get; set; }
        public DateTime Fregistro { get; set; }
        public short? Cperiodo { get; set; }
        public string Tobservacion { get; set; }
        public decimal Imonto { get; set; }
        public string Gestado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
