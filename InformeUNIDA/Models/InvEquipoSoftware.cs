using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class InvEquipoSoftware
    {
        public string NserieEquipo { get; set; }
        public int Csoftware { get; set; }
        public int Ntransaccion { get; set; }
        public string Gestado { get; set; }
        public DateTime Finstalacion { get; set; }
        public DateTime? Fdesinstalacion { get; set; }
        public string Cusuario { get; set; }
    }
}
