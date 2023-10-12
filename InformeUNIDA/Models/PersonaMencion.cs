using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaMencion
    {
        public int Cpersona { get; set; }
        public int Cmencion { get; set; }
        public short Ceducativo { get; set; }
        public string Sdenominacion { get; set; }
        public int Cciudad { get; set; }
        public string CalidadDe { get; set; }
        public string Sfecha { get; set; }
        public string Sobservaciones { get; set; }

        public virtual EnteEducativo CeducativoNavigation { get; set; }
        public virtual Persona CpersonaNavigation { get; set; }
    }
}
