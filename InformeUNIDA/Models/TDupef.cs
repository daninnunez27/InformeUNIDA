using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TDupef
    {
        public int Cpersona { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Nombre { get; set; }
        public string Dpersona { get; set; }
        public int MaxCpersona { get; set; }
        public int MinCpersona { get; set; }
        public int Cantidad { get; set; }
        public string Quees { get; set; }
        public int? Alterado { get; set; }
    }
}
