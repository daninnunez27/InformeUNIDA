using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class VCursorAula
    {
        public int Id { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFin { get; set; }
        public string Turno { get; set; }
        public short Caula { get; set; }
        public string Saula { get; set; }
        public short? Ncapacidad { get; set; }
        public string Lunes { get; set; }
        public string Martes { get; set; }
        public string Miercoles { get; set; }
        public string Jueves { get; set; }
        public string Viernes { get; set; }
        public string Sabado { get; set; }
    }
}
