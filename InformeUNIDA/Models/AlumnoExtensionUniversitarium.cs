using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoExtensionUniversitarium
    {
        public int Asistencia { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public int? Calumno { get; set; }
        public DateTime? Fechaasistencia { get; set; }
        public string Tipo { get; set; }
        public decimal? Cargahoraria { get; set; }
        public string Estado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
