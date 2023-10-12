using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BecaUnidum
    {
        public string Origen { get; set; }
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Carrera { get; set; }
        public decimal? Pf1 { get; set; }
        public decimal? Pf2 { get; set; }
        public decimal? Pe { get; set; }
        public decimal? Materias { get; set; }
        public decimal? PromCalifSemestre { get; set; }
        public decimal? Calumno { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? PromPuntaje { get; set; }
        public int? Periodo { get; set; }
        public string Turno { get; set; }
        public string PeriodoCursado1 { get; set; }
        public string PeriodoCursado2 { get; set; }
    }
}
