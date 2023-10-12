using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BloqueoSemana
    {
        public int Idbloqueo { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public int? TipoTarea { get; set; }
        public int? Estado { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Cmodificacion { get; set; }
    }
}
