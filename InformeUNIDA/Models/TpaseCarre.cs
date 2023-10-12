using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TpaseCarre
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cfacultad { get; set; }
        public short Ccarrera { get; set; }
        public string Dcarrera { get; set; }
        public string Scarrera { get; set; }
        public short? Nciclo { get; set; }
        public short Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short CcarreraEquiv { get; set; }
        public int? Norden { get; set; }
        public string Dtitulo { get; set; }
    }
}
