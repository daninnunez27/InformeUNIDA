using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EsquemaNotaDH
    {
        public short Cesquema { get; set; }
        public short GtipoNota { get; set; }
        public short? Nnivel { get; set; }
        public short? GsumaNota { get; set; }
        public short? GtipoCalculo { get; set; }
        public decimal? Nponderacion { get; set; }
        public short? NeliminaMenor { get; set; }
        public short? Gsustituye { get; set; }
        public short? Gcomplementa { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Norden { get; set; }
        public short? GtipoOrden { get; set; }
    }
}
