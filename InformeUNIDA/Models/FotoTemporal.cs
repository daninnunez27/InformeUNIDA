using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class FotoTemporal
    {
        public string Cpersona { get; set; }
        public byte[] Tfoto { get; set; }
        public string Descripcion { get; set; }
    }
}
