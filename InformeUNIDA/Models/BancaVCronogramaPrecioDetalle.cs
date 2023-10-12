using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaVCronogramaPrecioDetalle
    {
        public int Ccronograma { get; set; }
        public int Cprecio { get; set; }
        public int Cdefinicion { get; set; }
        public int Ncantidad { get; set; }
        public decimal Nprecio { get; set; }
    }
}
