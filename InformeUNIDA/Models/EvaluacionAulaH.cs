using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EvaluacionAulaH
    {
        public short Cevaluacion { get; set; }
        public short Gtipo { get; set; }
        public short Clocal { get; set; }
        public short Caula { get; set; }
        public string Daula { get; set; }
        public string Saula { get; set; }
        public short? Ncapacidad { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Nusado { get; set; }
        public string Spuerta { get; set; }
        public string Spabellon { get; set; }
        public short? Npiso { get; set; }
        public short? Norden { get; set; }
        public string Spuerta2 { get; set; }
    }
}
