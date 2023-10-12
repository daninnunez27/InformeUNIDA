using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaActualizacion
    {
        public int Cpersona { get; set; }
        public int Cactualizacion { get; set; }
        public string Sdenominacion { get; set; }
        public short Ceducativo { get; set; }
        public string Cclase { get; set; }
        public string Speriodo { get; set; }
        public decimal? NduracionHoras { get; set; }
        public string Sobservaciones { get; set; }

        public virtual Persona CpersonaNavigation { get; set; }
    }
}
