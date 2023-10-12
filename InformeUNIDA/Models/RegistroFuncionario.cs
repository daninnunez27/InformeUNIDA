using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class RegistroFuncionario
    {
        public int Cregistro { get; set; }
        public string Dfuncionario { get; set; }
        public string CiFuncionario { get; set; }
        public DateTime? FhoraEntrada { get; set; }
        public DateTime? FhoraAlmuerzoEntrada { get; set; }
        public DateTime? FhoraAlmuerzoSalida { get; set; }
        public DateTime? FhoraSalida { get; set; }
        public string PersonaRegistro { get; set; }
        public string IpRegistro { get; set; }
        public DateTime? Fcreacion { get; set; }
    }
}
