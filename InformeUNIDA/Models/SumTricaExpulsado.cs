using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SumTricaExpulsado
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Ccarrera { get; set; }
        public short Cperiodo { get; set; }
        public short Nsecuencia { get; set; }
        public string Speriodo { get; set; }
        public int NalumnosMatri { get; set; }
        public int? Nnuevos { get; set; }
        public int? Nantiguos { get; set; }
        public int Nbiqueros { get; set; }
        public int Ntriqueros { get; set; }
        public int Nexpulsados { get; set; }
        public int Negresados { get; set; }
        public int Nrecuperados { get; set; }
        public int Ndesertores { get; set; }
    }
}
