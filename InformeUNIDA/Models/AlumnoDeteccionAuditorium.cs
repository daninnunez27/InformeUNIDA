using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoDeteccionAuditorium
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Ccarrera { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public int ProcesoNumero { get; set; }
        public byte[] Informe1Archivo { get; set; }
        public string Informe1FileName { get; set; }
        public string Informe1ContentType { get; set; }
        public string Informe1Cmodificacion { get; set; }
        public DateTime? Informe1Fmodificacion { get; set; }
        public byte[] Comunicado1Archivo { get; set; }
        public string Comunicado1FileName { get; set; }
        public string Comunicado1ContentType { get; set; }
        public string Comunicado1Cmodificacion { get; set; }
        public DateTime? Comunicado1Fmodificacion { get; set; }
        public byte[] Informe2Archivo { get; set; }
        public string Informe2FileName { get; set; }
        public string Informe2ContentType { get; set; }
        public string Informe2Cmodificacion { get; set; }
        public DateTime? Informe2Fmodificacion { get; set; }
        public byte[] Comunicado2Archivo { get; set; }
        public string Comunicado2FileName { get; set; }
        public string Comunicado2ContentType { get; set; }
        public string Comunicado2Cmodificacion { get; set; }
        public DateTime? Comunicado2Fmodificacion { get; set; }
    }
}
