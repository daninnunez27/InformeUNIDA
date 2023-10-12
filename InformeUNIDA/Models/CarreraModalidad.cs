using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CarreraModalidad
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public short Ccarrera { get; set; }
        public int Cmodalidad { get; set; }
        public string Scategoria { get; set; }
        public string Ncategoria { get; set; }

        public virtual Carrera CcarreraNavigation { get; set; }
        public virtual Modalidad CmodalidadNavigation { get; set; }
    }
}
