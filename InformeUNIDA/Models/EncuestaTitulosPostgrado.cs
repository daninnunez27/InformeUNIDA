using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaTitulosPostgrado
    {
        public int Ctitulo { get; set; }
        public int Cencuesta { get; set; }
        public string Dtitulo { get; set; }
        public DateTime? Finicio { get; set; }
        public DateTime? Ffin { get; set; }
        public int? Nnivel { get; set; }
        public int? Narea { get; set; }

        public virtual EncuestaEgresado1 CencuestaNavigation { get; set; }
    }
}
