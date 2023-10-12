using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Convalidacion
    {
        public short Cactual { get; set; }
        public string Dactual { get; set; }
        public short Cnuevo { get; set; }
        public string Dnuevo { get; set; }
        public short GtipoAccion { get; set; }
        public short GtipoAprobacion { get; set; }
        public short Ccarrera { get; set; }
        public short Cperiodo { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public string Observacion { get; set; }
    }
}
