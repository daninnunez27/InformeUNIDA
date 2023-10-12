using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class VBibClasificacionInventario
    {
        public int Cclasificacion { get; set; }
        public int? NcantidadTotal { get; set; }
        public int? NcantidadPrestada { get; set; }
        public int? NcantidadReservada { get; set; }
        public int? NcantidadProtegido { get; set; }
        public int? NcantidadNoprestable { get; set; }
    }
}
