using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProgramaPension
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Gcategoria { get; set; }
        public decimal NimpMinimo { get; set; }
        public decimal NimpMaximo { get; set; }
    }
}
