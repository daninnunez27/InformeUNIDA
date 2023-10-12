using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Indicacion
    {
        public int Cindicacion { get; set; }
        public int Cconsulta { get; set; }
        public string Sindicacion { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual Consultum CconsultaNavigation { get; set; }
    }
}
