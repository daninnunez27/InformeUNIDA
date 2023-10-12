using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaCronogramaContenidoTemp
    {
        public int Ccronograma { get; set; }
        public int Ccontenido { get; set; }
        public int Calumno { get; set; }
        public DateTime Fvencimiento { get; set; }
        public decimal Nprecio { get; set; }
    }
}
