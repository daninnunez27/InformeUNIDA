using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LogEnviarCorreo
    {
        public int Clog { get; set; }
        public string TipoCorreo { get; set; }
        public string Correo { get; set; }
        public short? Estado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Calumno { get; set; }
        public string Tipo { get; set; }
        public string CorreoOtro { get; set; }
        public string Telefono { get; set; }
        public string Descripcion { get; set; }
    }
}
