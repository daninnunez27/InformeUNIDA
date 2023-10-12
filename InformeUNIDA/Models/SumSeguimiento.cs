using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SumSeguimiento
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public string Speriodo { get; set; }
        public short Nsecuencia { get; set; }
        public int Ccarrera { get; set; }
        public string Dcarrera { get; set; }
        public string Scarrera { get; set; }
        public int? Ceducativo { get; set; }
        public string Deducativo { get; set; }
        public string Gclasificacion { get; set; }
        public string Gcategoria { get; set; }
        public int? CperiodoIng { get; set; }
        public string SperiodoIng { get; set; }
        public short? NsecuenciaIng { get; set; }
        public short? Gmodalidad { get; set; }
        public string Dmodalidad { get; set; }
        public short? NcicloEquiv { get; set; }
        public string DcicloEquiv { get; set; }
        public int NalumnosMatri { get; set; }
        public int Nnuevos { get; set; }
        public int Nantiguos { get; set; }
        public int Nbiqueros { get; set; }
        public int Ntriqueros { get; set; }
        public int Negresados { get; set; }
        public int Nexpulsados { get; set; }
        public int NretirosDef { get; set; }
        public int Ndesertores { get; set; }
        public int Nrecuperados { get; set; }
        public int NretirosPer { get; set; }
        public int Nsuspendidos { get; set; }
        public int NcambioCarre { get; set; }
        public int NcambioCarreOut { get; set; }
        public int NquintoSup { get; set; }
        public int NtercioSup { get; set; }
    }
}
