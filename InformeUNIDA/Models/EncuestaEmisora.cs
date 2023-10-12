using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaEmisora
    {
        public int Idencuesta { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public string Radio { get; set; }
        public string Television { get; set; }
        public int? Estado { get; set; }
        public DateTime? Fechacreacion { get; set; }
        public string Otro { get; set; }
    }
}
