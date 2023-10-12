using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TipoExamenActa
    {
        public decimal Id { get; set; }
        public string TipoExamen { get; set; }
        public decimal? GtipoNota { get; set; }
    }
}
