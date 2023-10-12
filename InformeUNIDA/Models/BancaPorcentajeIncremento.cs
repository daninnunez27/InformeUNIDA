using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaPorcentajeIncremento
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Ccarrera { get; set; }
        public int Ccurricula { get; set; }
        public int Nciclo { get; set; }
        public decimal? Porcentaje { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
