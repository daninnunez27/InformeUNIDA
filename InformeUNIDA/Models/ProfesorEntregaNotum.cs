using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfesorEntregaNotum
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Cbloque { get; set; }
        public int Ccurso { get; set; }
        public int Cprofesor { get; set; }
        public int Cesquema { get; set; }
        public int GtipoNota { get; set; }
        public short Norden { get; set; }
        public short Gentrega { get; set; }
        public DateTime Fentrega { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
    }
}
