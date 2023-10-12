using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TablaGeneralCH
    {
        public short Ctabla { get; set; }
        public string Dtabla { get; set; }
        public string Stabla { get; set; }
        public short Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Caplicacion { get; set; }
        public int? Clog { get; set; }
    }
}
