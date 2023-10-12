using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PlanillaPeriodo
    {
        public int Cplanilla { get; set; }
        public short? Cperiodo { get; set; }
        public DateTime Finicio { get; set; }
        public DateTime Ffinal { get; set; }
        public int Gplanilla { get; set; }
        public int Greporte { get; set; }
        public DateTime? Fproceso { get; set; }
        public short Cinstitucion { get; set; }
        public int? GparametroOrigen { get; set; }
        public decimal? NmontoHora { get; set; }
        public string Dplanilla { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
