using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaDatoAcademicoPeriodo
    {
        public int Cperiodo { get; set; }
        public int Cprofesor { get; set; }
        public int? Tp1 { get; set; }
        public int? Tp2 { get; set; }
        public int? Tp3 { get; set; }
        public int? M1 { get; set; }
        public int? M2 { get; set; }
        public int? M3 { get; set; }
        public int? D1 { get; set; }
        public int? D2 { get; set; }
        public int? Di { get; set; }
        public int? E1 { get; set; }
        public int? E2 { get; set; }
        public int? E3 { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
