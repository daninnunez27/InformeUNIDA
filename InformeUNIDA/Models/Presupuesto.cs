using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Presupuesto
    {
        public int Cpresupuesto { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Ccarrera { get; set; }
        public int? TotalEstudiantes { get; set; }
        public int? CCuotas { get; set; }
        public int? NCuotas { get; set; }
        public int? Anio { get; set; }
        public int? Semestre { get; set; }
    }
}
