using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ResolucionArchivo
    {
        public int Cinstitucion { get; set; }
        public int Cfacultad { get; set; }
        public int TipoResolucion { get; set; }
        public int NroResolucion { get; set; }
        public int AnioResolucion { get; set; }
        public string NroResolucionCadena { get; set; }
        public decimal? NroResolucionOrden { get; set; }
        public byte[] Resolucion { get; set; }
        public string NombreArchivo { get; set; }
        public string TipoDocumento { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
