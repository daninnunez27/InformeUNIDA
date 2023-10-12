using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ActasExaman
    {
        public decimal Id { get; set; }
        public decimal? NumActa { get; set; }
        public decimal? Ccarrera { get; set; }
        public decimal? Ccurso { get; set; }
        public string TipoEx { get; set; }
        public string Sigla { get; set; }
    }
}
