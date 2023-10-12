using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PostulanteDocH
    {
        public short? Cadmision { get; set; }
        public int? Cpersona { get; set; }
        public short? GadmisionDoc { get; set; }
        public short? Gvisado { get; set; }
        public short? Grecibido { get; set; }
        public DateTime? Frecibido { get; set; }
        public string Crecibido { get; set; }
        public int? Cpostulante { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? GvisadoOtro { get; set; }
        public short? GrecibidoOtro { get; set; }
        public DateTime? FrecibidoOtro { get; set; }
        public string CrecibidoOtro { get; set; }
        public string CmodificacionOtro { get; set; }
        public DateTime? FmodificacionOtro { get; set; }
        public short? GvisadoEgresado { get; set; }
        public short? GrecibidoEgresado { get; set; }
        public string DescripcionEgresado { get; set; }
        public DateTime? FrecibidoEgresado { get; set; }
        public string CrecibidoEgresado { get; set; }
        public string CmodificacionEgresado { get; set; }
        public DateTime? FmodificacionEgresado { get; set; }
        public string Tipo { get; set; }
        public DateTime? Fauditoria { get; set; }
    }
}
