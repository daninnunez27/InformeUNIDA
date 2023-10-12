using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class StadMatriculaEvol
    {
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short Ccarrera { get; set; }
        public int Cmodalidad { get; set; }
        public int? Cestancia { get; set; }
        public string Aaaammdd { get; set; }
        public short? GtipoMatricula { get; set; }
        public DateTime? FprocesoMatricula { get; set; }
        public string Ccreacion { get; set; }
        public DateTime Fcreacion { get; set; }
        public int? Nvalor { get; set; }
        public int? Gtipoingreso { get; set; }
    }
}
