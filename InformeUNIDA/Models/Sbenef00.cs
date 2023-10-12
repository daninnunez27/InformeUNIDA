using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Sbenef00
    {
        public string Cempre { get; set; }
        public string Cprogr { get; set; }
        public DateTime Faaper { get; set; }
        public short Nperio { get; set; }
        public string Ccarre { get; set; }
        public int Nmatriculados { get; set; }
        public int NbenefProvi { get; set; }
        public decimal PbenefProvi { get; set; }
        public int NbenefDefin { get; set; }
        public decimal PbenefDefin { get; set; }
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Ccarrera { get; set; }
    }
}
