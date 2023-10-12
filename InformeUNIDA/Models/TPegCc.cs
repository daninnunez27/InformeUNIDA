using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TPegCc
    {
        public int Calumno { get; set; }
        public short? Ccurricula { get; set; }
        public short? Cperiodo { get; set; }
        public short Ccurso { get; set; }
        public short? Nciclo { get; set; }
        public int EsAprobado { get; set; }
        public int EsEquivalente { get; set; }
        public int GtipoAprobacion { get; set; }
        public int? Nmaxciccur { get; set; }
    }
}
