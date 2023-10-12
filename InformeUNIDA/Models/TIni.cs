using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TIni
    {
        public decimal? Nnota { get; set; }
        public decimal? NnotaSus { get; set; }
        public int Psus { get; set; }
        public decimal? NnotaCom { get; set; }
        public int Pcom { get; set; }
        public decimal? NnotaSum { get; set; }
        public int Psum { get; set; }
        public string DtipoNota { get; set; }
        public short GtipoNota { get; set; }
        public short? Nnivel { get; set; }
        public short GsumaNota { get; set; }
        public short? GtipoCalculo { get; set; }
        public decimal? Nponderacion { get; set; }
        public short? Gsustituye { get; set; }
        public short? Gcomplementa { get; set; }
    }
}
