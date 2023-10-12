using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Pagina
    {
        public short Cpagina { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public short? Padre { get; set; }
        public short? Orden { get; set; }
        public string Url { get; set; }
        public short? Estado { get; set; }
    }
}
