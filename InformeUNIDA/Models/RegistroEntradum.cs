using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class RegistroEntradum
    {
        public int Id { get; set; }
        public string Cingreso { get; set; }
        public string Nombre { get; set; }
        public DateTime? FechaDeIngreso { get; set; }
        public string TipoDeRegistro { get; set; }
        public string Ip { get; set; }
    }
}
