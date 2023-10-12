using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CalendarioAcademico
    {
        public int Cperiodo { get; set; }
        public int NroSemanaCalendario { get; set; }
        public DateTime? FechaInicioSemana { get; set; }
        public DateTime? FechaFinalSemana { get; set; }
        public int? NroSemanaAcademico { get; set; }
    }
}
