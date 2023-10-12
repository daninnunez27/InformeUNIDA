using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Equipo
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short Cequipo { get; set; }
        public string Dequipo { get; set; }
        public string Sequipo { get; set; }
        public short? Nequipos { get; set; }
        public short? Ndisponible { get; set; }
        public string Dobservacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
