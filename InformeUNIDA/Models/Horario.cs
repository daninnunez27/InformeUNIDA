using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Horario
    {
        public short Chorario { get; set; }
        public string Dhorario { get; set; }
        public string Shorario { get; set; }
        public short? GtipoHorario { get; set; }
        public short? Nsesion { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public decimal? Nhorasxsesion { get; set; }
        public short? Nminutosxsesion { get; set; }
    }
}
