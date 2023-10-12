using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Encuestacomentario
    {
        public int Cencuestacomentario { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Cbloque { get; set; }
        public int Ccurso { get; set; }
        public int Calumno { get; set; }
        public string Cuestionario { get; set; }
        public int? Cprofesor { get; set; }
        public int? Ccarrera { get; set; }
        public string Comentario { get; set; }
        public DateTime? Fecharegistro { get; set; }
        public string Scurso { get; set; }
    }
}
