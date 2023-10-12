using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TpaseApc
    {
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short GtipoCredito { get; set; }
        public decimal Ncredito { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
