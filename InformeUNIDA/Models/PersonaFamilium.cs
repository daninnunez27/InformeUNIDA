using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaFamilium
    {
        public int Cpersona { get; set; }
        public short Cfamilia { get; set; }
        public string Dfamilia { get; set; }
        public short? Gparentesco { get; set; }
        public short? Nedad { get; set; }
        public short? GestadoCivil { get; set; }
        public short? Ceducativo { get; set; }
    }
}
