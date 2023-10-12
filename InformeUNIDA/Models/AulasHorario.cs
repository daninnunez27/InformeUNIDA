using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AulasHorario
    {
        public decimal IdAulas { get; set; }
        public decimal? Id { get; set; }
        public DateTime? Horainicio { get; set; }
        public DateTime? Horafin { get; set; }
        public string Turno { get; set; }
        public decimal? Caula { get; set; }
        public string Saula { get; set; }
        public decimal? Ncapacidad { get; set; }
        public string Lunes { get; set; }
        public string Martes { get; set; }
        public string Miercoles { get; set; }
        public string Jueves { get; set; }
        public string Viernes { get; set; }
        public string Sabado { get; set; }
        public decimal? Estado { get; set; }
        public decimal? Alumnos { get; set; }
    }
}
