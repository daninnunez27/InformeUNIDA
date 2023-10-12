using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class RendimientoApp
    {
        public int Crendimiento { get; set; }
        public int? Cactividad { get; set; }
        public string Cprofesor { get; set; }
        public short? Ccurso { get; set; }
        public short? Cbloque { get; set; }
        public short? Cperiodo { get; set; }
        public string Cingreso { get; set; }
        public int? Drendimiento { get; set; }
        public DateTime? Fcreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Estado { get; set; }
    }
}
