using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoVirtual
    {
        public short Cperiodo { get; set; }
        public string Speriodo { get; set; }
        public int Calumno { get; set; }
        public string Cingreso { get; set; }
        public string Dpersona { get; set; }
        public string Dcarrera { get; set; }
        public int? Ccurso { get; set; }
        public string Scurso { get; set; }
        public string Dcurso { get; set; }
        public int? Cbloque { get; set; }
        public string Dbloque { get; set; }
        public string TclaveMat { get; set; }
        public string Nombre { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
    }
}
