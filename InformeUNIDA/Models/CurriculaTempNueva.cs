using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CurriculaTempNueva
    {
        public int? Nciclo { get; set; }
        public string ScursoU { get; set; }
        public string DcursoU { get; set; }
        public int? Ncreditos { get; set; }
        public int? Nhoras { get; set; }
        public string Prereq { get; set; }
    }
}
