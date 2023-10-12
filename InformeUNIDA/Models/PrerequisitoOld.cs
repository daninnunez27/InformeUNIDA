using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PrerequisitoOld
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Ccurricula { get; set; }
        public short Ccurso { get; set; }
        public short CcursoRequisito { get; set; }
        public short GtipoRequisito { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
