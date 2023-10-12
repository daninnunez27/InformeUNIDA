using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TpasePc
    {
        public short Cperiodo { get; set; }
        public short Ccurricula { get; set; }
        public short Ccarrera { get; set; }
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Chorario { get; set; }
        public short? Gdefault { get; set; }
        public short? CperiodoAnt { get; set; }
        public short? CcurriculaAnt { get; set; }
        public short? Cespecialidad { get; set; }
    }
}
