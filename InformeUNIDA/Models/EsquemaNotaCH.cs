using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EsquemaNotaCH
    {
        public short Cesquema { get; set; }
        public string Desquema { get; set; }
        public string Sesquema { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? GtipoEsquema { get; set; }
    }
}
