using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AsistWebProfesor
    {
        public short? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public short? Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public short? Ndia { get; set; }
        public DateTime? Hinicio { get; set; }
        public DateTime? Hfinal { get; set; }
        public int? Cprofesor { get; set; }
        public int? Caula { get; set; }
        public string CdireccionIp { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Dtema { get; set; }
        public DateTime? Fasistencia { get; set; }
    }
}
