using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaVPrecioDetalle
    {
        public int Ccatalogo { get; set; }
        public string Dcatalogo { get; set; }
        public int Ctarifa { get; set; }
        public string Dtarifa { get; set; }
        public int Cprecio { get; set; }
        public string Dprecio { get; set; }
        public int Cdefinicion { get; set; }
        public int Ncantidad { get; set; }
        public decimal Nprecio { get; set; }
        public string Ddefinicion { get; set; }
    }
}
