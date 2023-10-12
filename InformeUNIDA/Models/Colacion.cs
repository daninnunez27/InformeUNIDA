using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Colacion
    {
        public decimal Cpromocion { get; set; }
        public string Promocion { get; set; }
        public string Lema { get; set; }
        public DateTime? Fecha { get; set; }
        public string Lugar { get; set; }
        public DateTime? Hora { get; set; }
        public string Instrucciones { get; set; }
        public string Direccion { get; set; }
    }
}
