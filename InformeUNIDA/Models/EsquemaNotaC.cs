using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EsquemaNotaC
    {
        public EsquemaNotaC()
        {
            EsquemaNotaDs = new HashSet<EsquemaNotaD>();
        }

        public short Cesquema { get; set; }
        public string Desquema { get; set; }
        public string Sesquema { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short GtipoEsquema { get; set; }

        public virtual ICollection<EsquemaNotaD> EsquemaNotaDs { get; set; }
    }
}
