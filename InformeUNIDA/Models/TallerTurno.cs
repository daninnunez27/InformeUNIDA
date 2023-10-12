using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TallerTurno
    {
        public short Cturno { get; set; }
        public short Cevento { get; set; }
        public short Ctaller { get; set; }
        public short? Nturno { get; set; }
        public short Caula { get; set; }
        public DateTime Hinicio { get; set; }
        public DateTime Hfinal { get; set; }
        public short Nvacantes { get; set; }
        public short Ndisponibles { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
