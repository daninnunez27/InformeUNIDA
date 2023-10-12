using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AutorizacionCursoH
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public string Sorigen { get; set; }
        public short Ccurso { get; set; }
        public short GtipoAutorizacion { get; set; }
        public int? Cbloque { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Nautorizacion { get; set; }
        public string SusuarioAut { get; set; }
        public int? Clog { get; set; }
        public int IdCreacion { get; set; }
    }
}
