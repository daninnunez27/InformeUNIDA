using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Aviso
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Caviso { get; set; }
        public string Daviso { get; set; }
        public DateTime? Finicio { get; set; }
        public DateTime? Ffinal { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Cpersona { get; set; }
        public string GtipoAviso { get; set; }
        public int? TipoAviso { get; set; }
    }
}
