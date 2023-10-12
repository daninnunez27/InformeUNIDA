using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CngCuotaEsperadum
    {
        public DateTime? Fcreditos { get; set; }
        public int Calumno { get; set; }
        public short Cperiodo { get; set; }
        public short Ccarrera { get; set; }
        public int Cmodalidad { get; set; }
        public int? Ccronograma { get; set; }
        public int Ccontenido { get; set; }
        public string Cingreso { get; set; }
        public string Dpersona { get; set; }
        public string Dcarrera { get; set; }
        public string Turno { get; set; }
        public string Dcontenido { get; set; }
        public int? KCn { get; set; }
        public int? KNp { get; set; }
        public decimal? NmontoCn { get; set; }
        public decimal? NmontoCp { get; set; }
        public decimal? NmontoTotal { get; set; }
        public decimal? NmontoDescuento { get; set; }
        public decimal? NmontoNeto { get; set; }
    }
}
