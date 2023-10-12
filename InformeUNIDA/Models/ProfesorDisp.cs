using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfesorDisp
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Cprofesor { get; set; }
        public short Ndia { get; set; }
        public DateTime Hinicio { get; set; }
        public DateTime Hfinal { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual Profesor CprofesorNavigation { get; set; }
    }
}
