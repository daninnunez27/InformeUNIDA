using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EvaluacionExonera
    {
        public short Cevaluacion { get; set; }
        public int GtipoExonerado { get; set; }

        public virtual Evaluacion CevaluacionNavigation { get; set; }
    }
}
