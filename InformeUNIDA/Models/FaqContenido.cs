using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class FaqContenido
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Ccarrera { get; set; }
        public short? Gestado { get; set; }
        public short? Gubiacion { get; set; }
        public string Dcontenido { get; set; }
        public string Cusuario { get; set; }
        public string Cusuariomod { get; set; }
        public DateTime? Fcreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
