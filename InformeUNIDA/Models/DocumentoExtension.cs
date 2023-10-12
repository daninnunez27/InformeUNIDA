using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class DocumentoExtension
    {
        public int IdExtension { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public byte[] Extension { get; set; }
        public string TituloArchivo { get; set; }
        public string TipoArchivo { get; set; }
        public DateTime? Fcreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Cmodificacion { get; set; }
        public byte[] Informe { get; set; }
        public string TituloArchivoInforme { get; set; }
        public string TipoArchivoInforme { get; set; }
        public DateTime? FcreacionInforme { get; set; }
        public DateTime? FmodificacionInforme { get; set; }
        public string Ccreacion { get; set; }
        public int? Anio { get; set; }
        public int? Estado { get; set; }
    }
}
