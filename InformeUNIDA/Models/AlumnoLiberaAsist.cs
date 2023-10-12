using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoLiberaAsist
    {
        public int? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public int? Ccarrera { get; set; }
        public int? Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public int? CperiodoAnt { get; set; }
        public int? CcursoAnt { get; set; }
        public int? CbloqueAnt { get; set; }
        public short? GestadoFichaAnt { get; set; }
        public decimal? PfaltaAnt { get; set; }
        public decimal? PasistenciaAnt { get; set; }
        public decimal? Av1Ant { get; set; }
        public decimal? Av1eAnt { get; set; }
        public decimal? Av2Ant { get; set; }
        public decimal? Av2eAnt { get; set; }
        public decimal? PfAnt { get; set; }
        public decimal? Pfe1Ant { get; set; }
        public decimal? Pfe2Ant { get; set; }
        public short? GaprobadoAnt { get; set; }
        public string Sflag { get; set; }
    }
}
