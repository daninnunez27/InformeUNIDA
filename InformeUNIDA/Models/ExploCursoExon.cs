using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ExploCursoExon
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Nsecuencia { get; set; }
        public short? Ccarrera { get; set; }
        public int Ccurso { get; set; }
        public short? Cevaluacion { get; set; }
        public short? Carea { get; set; }
        public short? Cseccion { get; set; }
        public decimal NpuntajeDesde { get; set; }
        public decimal NpuntajeHasta { get; set; }
    }
}
