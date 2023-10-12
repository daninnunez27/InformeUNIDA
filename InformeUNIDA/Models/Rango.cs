using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Rango
    {
        public short Clocal { get; set; }
        public string Dtabla { get; set; }
        public int Nnumero { get; set; }
        public int Nmaximo { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
