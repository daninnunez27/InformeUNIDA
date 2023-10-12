using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AcreditacionArchivo
    {
        public int Id { get; set; }
        public int Item { get; set; }
        public int Subitem { get; set; }
        public byte[] Anexo { get; set; }
        public string NombreArchivo { get; set; }
        public string TipoDocumento { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Estado { get; set; }
        public int? Orden { get; set; }
        public int? RespSga { get; set; }
        public int? RespSgp { get; set; }
        public int? RespMarketing { get; set; }
        public int? RespRrhh { get; set; }
        public int? RespDecanato { get; set; }
        public int? RespDirreccionAcademico { get; set; }
        public int? RespFinanzas { get; set; }
        public int? RespBiblioteca { get; set; }
        public int? RespCoordinacion { get; set; }
        public int? RespAdmistracion { get; set; }
        public int? RespSistemas { get; set; }
        public int? RespLaboratorio { get; set; }
        public int? RespRectorado { get; set; }
        public int? RespSecretariaGeneral { get; set; }
        public string RespCmodificacion { get; set; }
        public DateTime? RespFmodificacion { get; set; }
    }
}
