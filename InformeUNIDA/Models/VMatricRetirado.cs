using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class VMatricRetirado
    {
        public string Scarrera { get; set; }
        public string Smodalidad { get; set; }
        public int Cmodalidad { get; set; }
        public int? MesMatriculado { get; set; }
        public int MesRetiro { get; set; }
        public int? Matriculado { get; set; }
        public int? Retiro { get; set; }
        public int? Activo { get; set; }
        public int? CantAlum { get; set; }
    }
}
