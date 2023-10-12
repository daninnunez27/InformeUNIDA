using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaObligacionContenidoH
    {
        public int Cobligacion { get; set; }
        public int Ccontenido { get; set; }
        public DateTime? Fvencimiento { get; set; }
        public string Sestado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string TsystemUser { get; set; }
        public int? Clog { get; set; }
        public DateTime? Fcontable { get; set; }
    }
}
