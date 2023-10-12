using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ValoracionGrupo
    {
        public int Cvaloraciongrupo { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cpersona { get; set; }
        public int? Cperiodo { get; set; }
        public int? Ccurso { get; set; }
        public int? Valoracionnumero { get; set; }
        public int? Ccarrera { get; set; }
        public int? Cgrupo { get; set; }
        public string Cevento { get; set; }
        public string Profesor { get; set; }
        public DateTime? Fcreacion { get; set; }
    }
}
