using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EducativoContacto
    {
        public short Ceducativo { get; set; }
        public short Ccontacto { get; set; }
        public string Dpaterno { get; set; }
        public string Dmaterno { get; set; }
        public string Dnombre { get; set; }
        public string Sexo { get; set; }
        public short Gcargo { get; set; }
        public string Stitulo { get; set; }
        public DateTime? Fnacimiento { get; set; }
        public string Tcorreo { get; set; }
        public string Stitulo1 { get; set; }
    }
}
