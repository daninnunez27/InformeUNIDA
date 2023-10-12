using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Participante
    {
        public int? Id { get; set; }
        public string Password { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime? Fechanac { get; set; }
        public int? Idartista { get; set; }
        public string NivelIngles { get; set; }
        public string InfOSist { get; set; }
    }
}
