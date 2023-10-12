using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaConcepto
    {
        public BancaConcepto()
        {
            BancaContenidos = new HashSet<BancaContenido>();
        }

        public int Cconcepto { get; set; }
        public string Dconcepto { get; set; }
        public string Sconcepto { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Sresultado { get; set; }
        public string Sorigen { get; set; }
        public int? Gestado { get; set; }
        public string Suso { get; set; }
        public int? Norden { get; set; }

        public virtual ICollection<BancaContenido> BancaContenidos { get; set; }
    }
}
