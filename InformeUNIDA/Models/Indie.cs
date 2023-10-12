using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Indie
    {
        public int Cindice { get; set; }
        public int Cclasificacion { get; set; }
        public string Ccapitulo { get; set; }
        public string Dindice { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual Clasificacion CclasificacionNavigation { get; set; }
    }
}
