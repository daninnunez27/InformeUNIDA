using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Motivo
    {
        public Motivo()
        {
            EncuestaMotivosInsatisfaccions = new HashSet<EncuestaMotivosInsatisfaccion>();
        }

        public int Cmotivo { get; set; }
        public string Dmotivo { get; set; }

        public virtual ICollection<EncuestaMotivosInsatisfaccion> EncuestaMotivosInsatisfaccions { get; set; }
    }
}
