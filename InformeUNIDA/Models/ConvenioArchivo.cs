using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ConvenioArchivo
    {
        public int Cinstitucion { get; set; }
        public int Cfacultad { get; set; }
        public int TipoConvenio { get; set; }
        public int NroConvenio { get; set; }
        public int AnioConvenio { get; set; }
        public string NroConvenioCadena { get; set; }
        public decimal? NroConvenioOrden { get; set; }
        public byte[] Convenio { get; set; }
        public string NombreArchivo { get; set; }
        public string TipoDocumento { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
