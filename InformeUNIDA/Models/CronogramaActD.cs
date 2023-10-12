using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CronogramaActD
    {
        public short Ccronograma { get; set; }
        public short Nsecuencia { get; set; }
        public string Dactividad { get; set; }
        public string Dobservacion { get; set; }
        public DateTime? Finicio { get; set; }
        public DateTime? Ffinal { get; set; }
    }
}
