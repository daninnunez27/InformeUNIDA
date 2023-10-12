using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaCronogramaContenido
    {
        public int Ccronograma { get; set; }
        public int Ccontenido { get; set; }
        public DateTime Fvencimiento { get; set; }
        public decimal NporcentajeInteresDiario { get; set; }
        public decimal NmontoGastoAdministrativo { get; set; }
        public int Crebaja { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public decimal? Imonto { get; set; }

        public virtual BancaContenido CcontenidoNavigation { get; set; }
        public virtual BancaCronograma CcronogramaNavigation { get; set; }
    }
}
