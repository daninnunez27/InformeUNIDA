using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlertaAlumnoSeguimiento
    {
        public int Ntransaccion { get; set; }
        public int? Cpersona { get; set; }
        public string Dusuario { get; set; }
        public string GtipoUsuario { get; set; }
        public DateTime Fmodificacion { get; set; }
        public string Dglosa { get; set; }
        public short Gestado { get; set; }
        public string Gvigencia { get; set; }
    }
}
