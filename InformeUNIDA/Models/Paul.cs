using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Paul
    {
        public short Cperiodo { get; set; }
        public string Cingreso { get; set; }
        public int Calumno { get; set; }
        public int Cpersona { get; set; }
        public short Ccarrera { get; set; }
        public int Cmodalidad { get; set; }
        public string Dturno { get; set; }
        public int? Cconvenio { get; set; }
        public int CconvenioNew { get; set; }
        public short? Cadmision { get; set; }
        public short Cevaluacion { get; set; }
        public short? GtipoExonerado { get; set; }
        public string Ditem { get; set; }
        public string Dpersona { get; set; }
    }
}
