using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CurriculaCambioCurricular
    {
        public int CcurriculaNueva { get; set; }
        public int CcurriculaAntigua { get; set; }
        public int CperiodoNuevo { get; set; }
        public int CperiodoAntiguo { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Carrera { get; set; }
        public int? Ccarrera { get; set; }
    }
}
