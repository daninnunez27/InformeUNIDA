using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TMigraCarre
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cfacultad { get; set; }
        public int? Ccarrera { get; set; }
        public string Dcarrera { get; set; }
        public string Scarrera { get; set; }
        public int Nciclo { get; set; }
        public int Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public int? Ccarre { get; set; }
        public int? Scategoria { get; set; }
        public int? ScategoriaAutom { get; set; }
        public int? CoCentCost { get; set; }
        public int? NcredPromPerio { get; set; }
        public int? NcursoPromPerio { get; set; }
        public int? CcarreraEquiv { get; set; }
        public int? NcursosIngresantes { get; set; }
    }
}
