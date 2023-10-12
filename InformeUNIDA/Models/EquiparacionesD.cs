using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EquiparacionesD
    {
        public int Id { get; set; }
        public int Ccurso { get; set; }
        public string Od { get; set; }
        public int? Ncredito { get; set; }

        public virtual EquiparacionesC IdNavigation { get; set; }
    }
}
