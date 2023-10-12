using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class InvEquipoAula
    {
        public short Caula { get; set; }
        public string NserieEquipo { get; set; }
        public short Nposicion { get; set; }
        public short Gestado { get; set; }
        public short? Cpabellon { get; set; }
        public DateTime Fasignacion { get; set; }
        public string Nip { get; set; }
        public string TgrupoTrabajo { get; set; }
        public DateTime? Fcese { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
