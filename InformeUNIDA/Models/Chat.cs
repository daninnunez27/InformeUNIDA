using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Chat
    {
        public int Cchat { get; set; }
        public int? Cperiodo { get; set; }
        public int? Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public int? Calumno { get; set; }
        public int? Cprofesor { get; set; }
        public string Opiniones { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
