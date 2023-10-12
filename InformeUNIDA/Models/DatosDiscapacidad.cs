using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class DatosDiscapacidad
    {
        public int IdDiscapacidad { get; set; }
        public int? Cpersona { get; set; }
        public int? Tipodiscapacidad { get; set; }
        public string Descripciondiscapacidad { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public int? Estado { get; set; }
    }
}
