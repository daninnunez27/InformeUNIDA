using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ActividadApp
    {
        public int Cactividad { get; set; }
        public string Cprofesor { get; set; }
        public short? Ccurso { get; set; }
        public short? Cbloque { get; set; }
        public short? Cperiodo { get; set; }
        public string Dlugar { get; set; }
        public string Ddescripcion { get; set; }
        public DateTime? Factividad { get; set; }
        public DateTime? Fcreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Estado { get; set; }
    }
}
