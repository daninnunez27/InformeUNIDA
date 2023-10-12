using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CargoAcademico
    {
        public short Cinstitucion { get; set; }
        public int Ccargo { get; set; }
        public short Gtipo { get; set; }
        public string Dcargo { get; set; }
        public string Scargo { get; set; }
        public short Estado { get; set; }
        public short? Cprograma { get; set; }
        public short? Ccarrera { get; set; }
        public int? CdependeCargo { get; set; }
    }
}
