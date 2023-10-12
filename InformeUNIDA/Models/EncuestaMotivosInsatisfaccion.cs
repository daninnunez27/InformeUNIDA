using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaMotivosInsatisfaccion
    {
        public int Cmotinsatis { get; set; }
        public int Cencuesta { get; set; }
        public int Cmotivo { get; set; }
        public int? Respuesta { get; set; }

        public virtual EncuestaEgresado1 CencuestaNavigation { get; set; }
        public virtual Motivo CmotivoNavigation { get; set; }
    }
}
