using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AutorizacionAlum
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public string Sorigen { get; set; }
        public int GtipoAutorizacion { get; set; }
        public short? Ncredito { get; set; }
        public int? Ncurso { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Nautorizacion { get; set; }
        public string SusuarioAut { get; set; }
    }
}
