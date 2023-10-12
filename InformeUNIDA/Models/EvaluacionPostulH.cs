using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EvaluacionPostulH
    {
        public short Cadmision { get; set; }
        public short Cevaluacion { get; set; }
        public int Cpersona { get; set; }
        public short Nexamen { get; set; }
        public short? Ceducativo { get; set; }
        public decimal? Npuntaje { get; set; }
        public short? NemisionCarnet { get; set; }
        public string Trespuesta { get; set; }
        public short? Gestado { get; set; }
        public string Cregistro { get; set; }
        public DateTime? Fregistro { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Gtipo { get; set; }
        public short? Clocal { get; set; }
        public short? Caula { get; set; }
        public int? Iconfirma { get; set; }
        public short? Imanual { get; set; }
        public short? Npuesto { get; set; }
        public string Spuerta { get; set; }
        public short? Scolegio { get; set; }
        public short? CevaluacionClave { get; set; }
        public DateTime? Fentrevista { get; set; }
        public int? GturnoCol { get; set; }
        public int? IbachillerHumanistico { get; set; }
        public int? IbachillerComercial { get; set; }
        public string TbachillerEnOtro { get; set; }
    }
}
