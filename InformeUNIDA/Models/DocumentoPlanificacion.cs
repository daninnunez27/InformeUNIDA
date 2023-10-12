using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class DocumentoPlanificacion
    {
        public int IdPlanificacion { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public byte[] Planificacion { get; set; }
        public string TituloArchivo { get; set; }
        public string TipoArchivo { get; set; }
        public DateTime? Fcreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Cmodificacion { get; set; }
        public string Ccreacion { get; set; }
        public int? Anio { get; set; }
        public int? Estado { get; set; }
    }
}
