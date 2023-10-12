using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ManualArchivo
    {
        public int Id { get; set; }
        public byte[] Manual { get; set; }
        public string NombreArchivo { get; set; }
        public string TipoArchivo { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
