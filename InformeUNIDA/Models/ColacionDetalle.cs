using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ColacionDetalle
    {
        public decimal Cpromocion { get; set; }
        public int Calumno { get; set; }
        public short Ccarrera { get; set; }
        public short Cperiodo { get; set; }
        public int? Cmodalidad { get; set; }
        public decimal Sumapuntajes { get; set; }
        public decimal Cexamenes { get; set; }
        public int Tieneconv { get; set; }
        public decimal Promedio { get; set; }
        public string Mencion { get; set; }
        public string Cingreso { get; set; }
        public string Cpersona { get; set; }
        public decimal? Cconva { get; set; }
        public decimal? Sumapuntajefinal { get; set; }
        public decimal? Cpfs { get; set; }
        public decimal? Cpasantias { get; set; }
        public decimal? Cmaterias { get; set; }
        public decimal? Crevalidas { get; set; }
    }
}
