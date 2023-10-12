using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class T2bsS
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public int? Cbloque { get; set; }
        public short? Ccurso { get; set; }
        public decimal Ndia { get; set; }
        public DateTime? Hinicio { get; set; }
        public decimal? Cprofesor { get; set; }
        public short? Caula { get; set; }
        public DateTime? Hfinal { get; set; }
        public int? GtipoHora { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public int? Cprofesor2 { get; set; }
    }
}
