using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoPromedioGeneral
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Ccarrera { get; set; }
        public int Calumno { get; set; }
        public int Cpersona { get; set; }
        public string Cingreso { get; set; }
        public decimal? Nacumulado { get; set; }
        public short? CperiodoUltimo { get; set; }
    }
}
