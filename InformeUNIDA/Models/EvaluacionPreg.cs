using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EvaluacionPreg
    {
        public short Cevaluacion { get; set; }
        public short Npregunta { get; set; }
        public short Carea { get; set; }
        public short Cseccion { get; set; }
        public string Tsolucion { get; set; }
        public decimal? NpesoBuena { get; set; }
        public decimal? NpesoMala { get; set; }
        public decimal? NpesoBlanco { get; set; }
        public decimal? NpesoConfuso { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
