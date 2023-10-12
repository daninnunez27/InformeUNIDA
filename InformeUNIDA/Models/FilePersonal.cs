using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class FilePersonal
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public short? Ccarrera { get; set; }
        public int? Calumno { get; set; }
        public int Cpersona { get; set; }
        public int Nregistro { get; set; }
        public int? Cprofesor { get; set; }
        public short GtipoRegistro { get; set; }
        public DateTime Fregistro { get; set; }
        public string Dobservacion { get; set; }
        public string Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public int? Gcaso { get; set; }
        public string SusuarioAut { get; set; }
    }
}
