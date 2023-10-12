using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PacmanResultado
    {
        public int Id { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public int Calumno { get; set; }
        public int? Puntaje { get; set; }
        public DateTime? Fcreacion { get; set; }
    }
}
