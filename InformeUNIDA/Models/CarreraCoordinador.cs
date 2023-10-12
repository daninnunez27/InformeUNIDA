using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CarreraCoordinador
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Ccarrera { get; set; }
        public short Cprofesor { get; set; }
        public short? Gestado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
