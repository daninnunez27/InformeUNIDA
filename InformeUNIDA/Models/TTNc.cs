using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TTNc
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short Ccurso { get; set; }
        public decimal? Npromedio { get; set; }
        public string Tpromedio { get; set; }
        public short GtipoAprobacion { get; set; }
        public short GaprobadoMigrado { get; set; }
        public short Gmigrado { get; set; }
        public short Cobservacion { get; set; }
        public short GpromCero { get; set; }
        public short? Gaprobado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public decimal? NpromedioBk { get; set; }
        public int? Ccurricula { get; set; }
        public DateTime? Fcalculo { get; set; }
    }
}
