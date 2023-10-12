using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AcLgPractica
    {
        public int CodigoPractica { get; set; }
        public string Abreviatura { get; set; }
        public string Nombre { get; set; }
        public string Ip { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
