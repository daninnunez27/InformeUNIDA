using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class InstructivoArchivo
    {
        public short Cinstructivo { get; set; }
        public string Cinstitucion { get; set; }
        public int? Cfacultad { get; set; }
        public int? TipoResolucion { get; set; }
        public string NroResolucionCadena { get; set; }
        public int? AnioResolucion { get; set; }
        public int? Grupo { get; set; }
        public byte[] Instructivo { get; set; }
        public string NombreArchivo { get; set; }
        public string TipoDocumento { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
