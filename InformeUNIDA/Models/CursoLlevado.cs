using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CursoLlevado
    {
        public int Calumno { get; set; }
        public short Ccurricula { get; set; }
        public short Cperiodo { get; set; }
        public short Ccurso { get; set; }
        public string GtipoAprobacion { get; set; }
        public string Npromedio { get; set; }
    }
}
