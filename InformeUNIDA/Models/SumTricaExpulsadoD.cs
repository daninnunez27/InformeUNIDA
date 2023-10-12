using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SumTricaExpulsadoD
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Ccarrera { get; set; }
        public short Cperiodo { get; set; }
        public short Nsecuencia { get; set; }
        public string Speriodo { get; set; }
        public int Cdepartamento { get; set; }
        public int Carea { get; set; }
        public int Ccurso { get; set; }
        public string Dcurso { get; set; }
        public string Scurso { get; set; }
        public int? Nmatriculados { get; set; }
        public int Nbiqueros { get; set; }
        public int Ntriqueros { get; set; }
        public int Nexpulsados { get; set; }
    }
}
