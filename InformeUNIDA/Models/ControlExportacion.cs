using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ControlExportacion
    {
        public int Nexportacion { get; set; }
        public string Dquery { get; set; }
        public string Dventana { get; set; }
        public short Gestado { get; set; }
        public string Cusuario { get; set; }
        public DateTime? Fexportacion { get; set; }
    }
}
