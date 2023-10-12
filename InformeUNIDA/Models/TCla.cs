using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TCla
    {
        public int Cclasificacion { get; set; }
        public string Dclasificacion { get; set; }
        public string Sclasificacion { get; set; }
        public int Gdominio { get; set; }
        public int Cestructura { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Tbackup { get; set; }
    }
}
