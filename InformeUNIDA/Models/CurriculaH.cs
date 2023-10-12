using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CurriculaH
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Ccurricula { get; set; }
        public short Ccarrera { get; set; }
        public string Dcurricula { get; set; }
        public string Scurricula { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public DateTime? Fdesde { get; set; }
        public int? CperiodoInicio { get; set; }
    }
}
