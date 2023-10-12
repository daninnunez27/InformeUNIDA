using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class RegistroEntradaApp
    {
        public int IdRegistro { get; set; }
        public string Cingreso { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaDeIngreso { get; set; }
        public string PersonaRegistro { get; set; }
        public int? Cbloque { get; set; }
        public int? Ccurso { get; set; }
        public string Cperiodo { get; set; }
    }
}
