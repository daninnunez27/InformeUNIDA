using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AutorizacionBloqueCursoFecha
    {
        public int Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public int GtipoNota { get; set; }
        public int? CprofesorRegistro { get; set; }
        public int Nautorizacion { get; set; }
        public string Motivo { get; set; }
        public string Cautorizacion { get; set; }
        public DateTime? Fautorizacion { get; set; }
        public string Seguimiento { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Gestado { get; set; }
    }
}
