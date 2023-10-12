using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ReservaEquipo
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cequipo { get; set; }
        public int Cprofesor { get; set; }
        public short Ccurso { get; set; }
        public short Cbloque { get; set; }
        public short Caula { get; set; }
        public DateTime FreservaInicio { get; set; }
        public DateTime FreservaFin { get; set; }
        public string Dobservacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
