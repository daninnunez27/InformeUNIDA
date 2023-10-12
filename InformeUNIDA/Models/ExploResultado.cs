using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ExploResultado
    {
        public int Cevaluacion { get; set; }
        public int Cpersona { get; set; }
        public int Ccarrera { get; set; }
        public short Carea { get; set; }
        public short Cseccion { get; set; }
        public int Ccurso { get; set; }
        public decimal? Npuntaje { get; set; }
        public string Sprocesa { get; set; }
    }
}
