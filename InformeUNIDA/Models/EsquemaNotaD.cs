using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EsquemaNotaD
    {
        public short Cesquema { get; set; }
        public short GtipoNota { get; set; }
        public short Norden { get; set; }
        public short Nnivel { get; set; }
        public short GsumaNota { get; set; }
        public short GtipoCalculo { get; set; }
        public short Gsustituye { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? GcomplementaX { get; set; }
        public short? GtipoOrdenX { get; set; }
        public short? GeliminaFijaX { get; set; }
        public short? NeliminaMenorX { get; set; }
        public short? CinstitucionX { get; set; }
        public short? CprogramaX { get; set; }
        public decimal? Nponderacion { get; set; }

        public virtual EsquemaNotaC CesquemaNavigation { get; set; }
    }
}
