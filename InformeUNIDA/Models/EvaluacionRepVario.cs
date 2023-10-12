using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EvaluacionRepVario
    {
        public short? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public short Creporte { get; set; }
        public string Dreporte { get; set; }
        public int Cevaluacion { get; set; }
    }
}
