using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TipoCambio
    {
        public int Nregistro { get; set; }
        public DateTime Fproceso { get; set; }
        public string Gmoneda { get; set; }
        public decimal Ivalor { get; set; }
        public string Svigen { get; set; }
        public string Ccreacion { get; set; }
        public DateTime Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
