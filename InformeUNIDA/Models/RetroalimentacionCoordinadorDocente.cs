using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class RetroalimentacionCoordinadorDocente
    {
        public int Id { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public int? Cbloque { get; set; }
        public int? Ccurso { get; set; }
        public int? Ccarrera { get; set; }
        public int? Cprofesor { get; set; }
        public int? CusuarioCoordinador { get; set; }
        public string Drecomendacion { get; set; }
        public string Cuestionario { get; set; }
        public DateTime? Fcreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
