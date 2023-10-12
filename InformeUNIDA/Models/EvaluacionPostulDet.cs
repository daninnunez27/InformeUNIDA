using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EvaluacionPostulDet
    {
        public int Cadmision { get; set; }
        public int Cevaluacion { get; set; }
        public short? Nmarcadas { get; set; }
        public int Cpersona { get; set; }
        public short Carea { get; set; }
        public short Cseccion { get; set; }
        public short? Nbuenas { get; set; }
        public short? Nmalas { get; set; }
        public short? Nblanco { get; set; }
        public short? Npuntaje { get; set; }
    }
}
