using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaObligacionBeneficioH
    {
        public int Cobligacion { get; set; }
        public int Ccontenido { get; set; }
        public decimal? Nporcentaje { get; set; }
        public string Tbeneficio { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string TsystemUser { get; set; }
        public int? Clog { get; set; }
        public string Ctipo { get; set; }
        public DateTime? Fauditoria { get; set; }
    }
}
