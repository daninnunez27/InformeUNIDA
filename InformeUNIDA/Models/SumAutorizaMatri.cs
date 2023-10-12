using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SumAutorizaMatri
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public string GtipoPermiso { get; set; }
        public short GtipoAutorizacion { get; set; }
        public int? Ccurso { get; set; }
        public int Ccarrera { get; set; }
        public string SusuarioReg { get; set; }
        public string SusuarioAut { get; set; }
        public int Nautorizaciones { get; set; }
    }
}
