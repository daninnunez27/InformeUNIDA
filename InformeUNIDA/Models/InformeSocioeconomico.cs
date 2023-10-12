using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class InformeSocioeconomico
    {
        public int Cise { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Ccarrera { get; set; }
        public int? Cperiodo { get; set; }
        public int? Cpersona { get; set; }
        public int? Cdepartamento { get; set; }
        public int? Cprovincia { get; set; }
        public int? Cdistrito { get; set; }
        public string Tdireccion { get; set; }
        public string Pregunta { get; set; }
        public string Respuesta { get; set; }
        public string Observacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public int? Anio { get; set; }
    }
}
