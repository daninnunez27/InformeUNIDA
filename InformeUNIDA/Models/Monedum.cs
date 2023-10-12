using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Monedum
    {
        public int Moneda { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
        public string Pais { get; set; }
        public string Simbolo { get; set; }
    }
}
