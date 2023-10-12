using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ParticipacionEstudiante
    {
        public int? Cprofesor { get; set; }
        public string Nombre { get; set; }
        public string Baja { get; set; }
        public string Media { get; set; }
        public string Alta { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cperiodo { get; set; }
    }
}
