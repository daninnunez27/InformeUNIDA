using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class NotaCredebD
    {
        public int CtipoNota { get; set; }
        public int Ncredeb { get; set; }
        public int Cobligacion { get; set; }
        public int Ccontenido { get; set; }
        public int Calumno { get; set; }
        public int Cpersona { get; set; }
        public decimal Itneto { get; set; }
        public DateTime Fcreacion { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Cmodificacion { get; set; }
    }
}
