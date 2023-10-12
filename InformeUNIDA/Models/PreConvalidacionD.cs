using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PreConvalidacionD
    {
        public int Nconvalidacion { get; set; }
        public int Ccurso { get; set; }
        public int Npromedio { get; set; }
        public string Gobservacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
