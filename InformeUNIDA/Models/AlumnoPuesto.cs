using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoPuesto
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public short? Ccarrera { get; set; }
        public short? Cmodalidad { get; set; }
        public int? Calumno { get; set; }
        public decimal? Nacumulado { get; set; }
        public short? Npuesto { get; set; }
        public short? Nsecuencia { get; set; }
        public short? Gestado { get; set; }
        public short? Nalumnos { get; set; }
        public string Dsegmento { get; set; }
    }
}
