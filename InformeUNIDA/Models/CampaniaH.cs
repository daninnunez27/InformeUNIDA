using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CampaniaH
    {
        public short Ccampania { get; set; }
        public string Dcampania { get; set; }
        public string Scampania { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Gestado { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
    }
}
