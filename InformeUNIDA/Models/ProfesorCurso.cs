using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfesorCurso
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cprofesor { get; set; }
        public short Ccurso { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual Profesor CprofesorNavigation { get; set; }
    }
}
