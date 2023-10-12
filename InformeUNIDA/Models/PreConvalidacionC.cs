using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PreConvalidacionC
    {
        public int Nconvalidacion { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Cadmision { get; set; }
        public int Cpersona { get; set; }
        public int Ccarrera { get; set; }
        public short Cespecialidad { get; set; }
        public int Ccurricula { get; set; }
        public short Gestado { get; set; }
        public string Cresponsable { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
