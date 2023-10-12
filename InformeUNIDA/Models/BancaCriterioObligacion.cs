using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaCriterioObligacion
    {
        public int CgrupoCriterio { get; set; }
        public int Cperiodo { get; set; }
        public int Ccarrera { get; set; }
        public int Cmodalidad { get; set; }
        public int Cestancia { get; set; }
        public int Ccronograma { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int Ccriterio { get; set; }
    }
}
