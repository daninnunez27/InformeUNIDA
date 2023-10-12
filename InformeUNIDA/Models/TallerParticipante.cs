using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TallerParticipante
    {
        public short Cevento { get; set; }
        public short Ctaller { get; set; }
        public short Cturno { get; set; }
        public int Cpersona { get; set; }
        public string Gasistencia { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Gconfirmacion { get; set; }
        public string Gnousil { get; set; }
    }
}
