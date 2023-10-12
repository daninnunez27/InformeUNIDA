using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoPrereq
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public string Cingreso { get; set; }
        public string Dpersona { get; set; }
        public string Dcarrera { get; set; }
        public int? Ccurso { get; set; }
        public string Scurso { get; set; }
        public string Dcurso { get; set; }
        public int? Cbloque { get; set; }
        public string Dbloque { get; set; }
        public int? CcursoPr { get; set; }
        public string ScursoPr { get; set; }
        public string DcursoPr { get; set; }
        public short? Gaprobado { get; set; }
        public string Daprobado { get; set; }
        public DateTime? Fproceso { get; set; }
    }
}
