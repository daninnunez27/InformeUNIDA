using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class VBibObjetoPrestado
    {
        public string Dclasificacion { get; set; }
        public string Sclasificacion { get; set; }
        public string Tautor { get; set; }
        public int? Nacceso { get; set; }
        public string Sobjeto { get; set; }
        public int Cobjeto { get; set; }
        public int Cmovimiento { get; set; }
        public int? Cpersona { get; set; }
        public DateTime? Fhestado { get; set; }
    }
}
