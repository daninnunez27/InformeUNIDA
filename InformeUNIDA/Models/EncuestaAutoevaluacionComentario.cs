using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaAutoevaluacionComentario
    {
        public int Cencuestacomentario { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Cprofesor { get; set; }
        public string Cuestionario { get; set; }
        public string Comentario { get; set; }
        public DateTime? Fecharegistro { get; set; }
        public int NumeroEncuesta { get; set; }
    }
}
