using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CorreoMasivoC
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Cpersona { get; set; }
        public int Ncorreo { get; set; }
        public DateTime Fcorreo { get; set; }
        public short Nenvio { get; set; }
        public string Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public DateTime Fmodificacion { get; set; }
    }
}
