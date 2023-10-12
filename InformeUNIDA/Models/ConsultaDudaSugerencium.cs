using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ConsultaDudaSugerencium
    {
        public int Ccds { get; set; }
        public int? Cperiodo { get; set; }
        public int? Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public int? Cprofesor { get; set; }
        public int? CcdsPadre { get; set; }
        public int? Calumno { get; set; }
        public int? TipoCds { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public string TipoPersona { get; set; }
        public int? Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
