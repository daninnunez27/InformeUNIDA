using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class T2ncA
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public short? Ccurso { get; set; }
        public int? Npromedio { get; set; }
        public int? Tpromedio { get; set; }
        public int GtipoAprobacion { get; set; }
        public int GaprobadoMigrado { get; set; }
        public int Gmigrado { get; set; }
        public int Cobservacion { get; set; }
        public int GpromCero { get; set; }
        public int Gaprobado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public string NpromedioBk { get; set; }
        public int Ccurricula { get; set; }
        public DateTime? Fcalculo { get; set; }
    }
}
