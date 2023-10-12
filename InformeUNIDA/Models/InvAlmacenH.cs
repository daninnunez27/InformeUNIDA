using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class InvAlmacenH
    {
        public short? Clocal { get; set; }
        public short? Calmacen { get; set; }
        public string Dalmacen { get; set; }
        public string Salmacen { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
