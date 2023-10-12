using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TPegCc2
    {
        public int Calumno { get; set; }
        public short? Ccurricula { get; set; }
        public short? Cperiodo { get; set; }
        public int? Cantidad { get; set; }
        public int? Aprobados { get; set; }
        public int? Desaprobado { get; set; }
        public int? MinCicJalado { get; set; }
        public int? NcursoUltimoCiclo { get; set; }
        public int? NaprobadoUltimoCiclo { get; set; }
        public int? NjaladoNoUltimoCiclo { get; set; }
        public string Tcomentario { get; set; }
    }
}
