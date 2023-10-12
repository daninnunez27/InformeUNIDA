using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CombinacionesInsert
    {
        public decimal IdCombinacion { get; set; }
        public decimal? Cantidad1 { get; set; }
        public decimal? Capacidad1 { get; set; }
        public decimal? Cantidad2 { get; set; }
        public decimal? Capacidad2 { get; set; }
        public decimal? Alumnos { get; set; }
        public decimal? SumAulas { get; set; }
        public decimal? Libres { get; set; }
    }
}
