using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EAlumnoAsist
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Cbloque { get; set; }
        public short Ccurso { get; set; }
        public DateTime Hinicio { get; set; }
        public DateTime Fasistencia { get; set; }
        public int Calumno { get; set; }
        public short Nsesion { get; set; }
    }
}
