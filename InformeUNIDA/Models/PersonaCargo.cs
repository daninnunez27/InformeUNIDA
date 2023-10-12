using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaCargo
    {
        public short Cinstitucion { get; set; }
        public int Ccargo { get; set; }
        public int Cpersona { get; set; }
        public int Cusuario { get; set; }
        public short Estado { get; set; }
    }
}
