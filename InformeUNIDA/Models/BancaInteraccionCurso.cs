using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaInteraccionCurso
    {
        public int Cinteraccion { get; set; }
        public int Ccurso { get; set; }
        public int NcreditoReal { get; set; }
        public int GtipoCredito { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual BancaInteraccion CinteraccionNavigation { get; set; }
    }
}
