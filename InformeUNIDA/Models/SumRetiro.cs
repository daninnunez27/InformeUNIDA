using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SumRetiro
    {
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public int? Ccarrera { get; set; }
        public string Gnuevo { get; set; }
        public int? Gmotivo { get; set; }
        public int? Nretiros { get; set; }
        public decimal? PorRet { get; set; }
        public decimal? PorTot { get; set; }
        public int? NretirosAnt { get; set; }
        public int? CperiodoAnt { get; set; }
        public decimal? PorRetCar { get; set; }
        public decimal? PorTotCar { get; set; }
    }
}
