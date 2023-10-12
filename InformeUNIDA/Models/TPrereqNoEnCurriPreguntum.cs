using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TPrereqNoEnCurriPreguntum
    {
        public string Dcurricula { get; set; }
        public string Dcarrera { get; set; }
        public string Dcurso { get; set; }
        public string DcursoReq { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public short Ccurricula { get; set; }
        public short Ccurso { get; set; }
        public short? CcursoRequisito { get; set; }
        public int GtipoRequisto { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public int Dato { get; set; }
        public string Grupo { get; set; }
        public string Disciplina { get; set; }
        public string Asociado { get; set; }
    }
}
