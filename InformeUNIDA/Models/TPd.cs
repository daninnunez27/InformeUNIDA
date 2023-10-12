using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TPd
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Ccarrera { get; set; }
        public int Calumno { get; set; }
        public int Cpersona { get; set; }
        public string Cingreso { get; set; }
        public string Dpersona { get; set; }
        public string Sestado { get; set; }
        public string Scarrera { get; set; }
        public short CertEstRecibido { get; set; }
        public short CertEstVisado { get; set; }
        public short TitBacColRecibido { get; set; }
        public short TitBacColVisado { get; set; }
        public int ConPop { get; set; }
        public int Nregistro { get; set; }
        public int? ConCompromiso { get; set; }
        public string Tobservacion { get; set; }
        public int? Suma { get; set; }
        public string Tsituacion { get; set; }
    }
}
