using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoReclamoC
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Cevento { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public short GtipoNota { get; set; }
        public DateTime Fevento { get; set; }
        public int Cprofesor { get; set; }
        public DateTime? FrecojoPack { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
