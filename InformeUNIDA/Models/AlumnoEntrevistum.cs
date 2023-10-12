using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoEntrevistum
    {
        public int Centrevista { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Calumno { get; set; }
        public byte[] Entrevista { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string CmodificacionEntrevista { get; set; }
        public DateTime? FmodificacionEntrevista { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
