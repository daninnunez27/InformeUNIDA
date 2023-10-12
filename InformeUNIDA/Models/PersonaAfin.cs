using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaAfin
    {
        public int Cpersona { get; set; }
        public int CpersonaAfin { get; set; }
        public short Gafinidad { get; set; }
        public short? GnivelAfin { get; set; }
        public short? Gemergencia { get; set; }
    }
}
