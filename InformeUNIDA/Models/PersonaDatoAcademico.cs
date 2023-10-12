using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaDatoAcademico
    {
        public int Cpersona { get; set; }
        public int Item { get; set; }
        public int? Clugar { get; set; }
        public int? Cpais { get; set; }
        public int? CnivelAcademico { get; set; }
        public int? CtipoInstitucion { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Ccarrera { get; set; }
        public int? Ctitulo { get; set; }
        public string AnioEgreso { get; set; }
        public int? Estado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
