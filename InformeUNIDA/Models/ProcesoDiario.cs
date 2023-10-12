using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProcesoDiario
    {
        public int? Nproceso { get; set; }
        public DateTime? Fproceso { get; set; }
        public short? Nsecuencia { get; set; }
        public string Dproceso { get; set; }
        public DateTime? Finicio { get; set; }
        public DateTime? Ffin { get; set; }
        public string Dmensaje { get; set; }
    }
}
