using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EProfesorAsist
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Cbloque { get; set; }
        public short Ccurso { get; set; }
        public DateTime Hinicio { get; set; }
        public short Cprofesor { get; set; }
        public DateTime FinicioAsist { get; set; }
        public DateTime? FfinalAsist { get; set; }
        public short NvecesGrabo { get; set; }
        public short Gcerrado { get; set; }
        public short Gestado { get; set; }
    }
}
