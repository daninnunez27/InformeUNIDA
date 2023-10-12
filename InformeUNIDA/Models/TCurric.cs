using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TCurric
    {
        public string Scurricula { get; set; }
        public string Curriculo { get; set; }
        public string Carrera { get; set; }
        public string Turno { get; set; }
        public int OrdenTurno { get; set; }
        public int? Cantidad { get; set; }
        public int Usar { get; set; }
        public int? Existe { get; set; }
        public string ScurriculaNuevo { get; set; }
        public string DcurriculaNuevo { get; set; }
        public int? Ccurricula2 { get; set; }
        public int? Ccurricula { get; set; }
    }
}
