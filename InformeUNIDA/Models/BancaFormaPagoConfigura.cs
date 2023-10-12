using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaFormaPagoConfigura
    {
        public int Cperiodo { get; set; }
        public string SquePagar { get; set; }
        public string SmedioPago { get; set; }
        public DateTime Flimite { get; set; }
        public decimal NporcentajeDescuento { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
