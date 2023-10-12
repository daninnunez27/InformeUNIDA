using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CursoCoordinador
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Cprofesor { get; set; }
        public short? Cprofesor2 { get; set; }
        public short Ccurso { get; set; }

        public virtual Profesor CprofesorNavigation { get; set; }
    }
}
