using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CurriculaCcAnalisisOverload
    {
        public int? Ccurricula { get; set; }
        public string Carrera { get; set; }
        public int? Calumno { get; set; }
        public int? CredTotalCa { get; set; }
        public int? CredTotalCn { get; set; }
        public int? CredAprobados { get; set; }
        public int? CredPendCa { get; set; }
        public int? CredPendCn { get; set; }
        public int? CredNuevosCn { get; set; }
        public int? CredEquiparados { get; set; }
    }
}
