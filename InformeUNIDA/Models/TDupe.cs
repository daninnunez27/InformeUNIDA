using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TDupe
    {
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Nombre { get; set; }
        public int? Cantidad { get; set; }
        public int? MinCpersona { get; set; }
        public int? MaxCpersona { get; set; }
        public string Quees { get; set; }
    }
}
