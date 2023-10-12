using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TAcueBcc
    {
        public int? Ccronograma { get; set; }
        public int? Ccontenido { get; set; }
        public string Fvencimiento { get; set; }
        public decimal NporcentajeInteresDiario { get; set; }
        public int NmontoGastoAdministrativo { get; set; }
        public int Crebaja { get; set; }
        public string Ccreacion { get; set; }
        public DateTime Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
    }
}
