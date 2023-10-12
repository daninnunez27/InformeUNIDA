using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SumSeguimDet
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public string Speriodo { get; set; }
        public short Nsecuencia { get; set; }
        public int Ccarrera { get; set; }
        public int Cdepartamento { get; set; }
        public int Carea { get; set; }
        public string Darea { get; set; }
        public int Ccurso { get; set; }
        public string Dcurso { get; set; }
        public string Scurso { get; set; }
        public int Nmatriculados { get; set; }
        public int Nbiqueros { get; set; }
        public int Ntriqueros { get; set; }
        public int Nexpulsados { get; set; }
    }
}
