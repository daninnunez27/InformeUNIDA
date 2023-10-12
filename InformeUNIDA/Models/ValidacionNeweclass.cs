using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ValidacionNeweclass
    {
        public int IdValidacion { get; set; }
        public string Dvalidacion { get; set; }
        public string AprobadoPor { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Finicio { get; set; }
        public DateTime? Ffinal { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Cmodificacion { get; set; }
        public int? Estado { get; set; }
        public int? Ctipovalidacion { get; set; }
        public string Dtipovalidacion { get; set; }
    }
}
