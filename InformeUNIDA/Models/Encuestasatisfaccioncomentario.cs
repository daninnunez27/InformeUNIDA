using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Encuestasatisfaccioncomentario
    {
        public int Cencuestacomentario { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Codigo { get; set; }
        public string Cuestionario { get; set; }
        public int Ccarrera { get; set; }
        public string Comentario { get; set; }
        public DateTime? Fecharegistro { get; set; }
        public string Tipopersona { get; set; }
    }
}
