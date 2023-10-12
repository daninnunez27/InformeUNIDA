using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TNcA
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public short? Ccurso { get; set; }
        public int? Npromedio { get; set; }
        public int GtipoAprobacion { get; set; }
        public int Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public int? Gnaturaleza { get; set; }
        public int? Tpromedio { get; set; }
        public int? Cbloque { get; set; }
        public int? Nvez { get; set; }
        public int? NvezReal { get; set; }
        public decimal? Ncredito { get; set; }
        public string Dcurso { get; set; }
        public string Scurso { get; set; }
        public int Gcondicion { get; set; }
        public int? Cesquema { get; set; }
        public int GtipoEsquema { get; set; }
        public int? Tflags { get; set; }
        public int? Ccarrera { get; set; }
        public int? Nciclo { get; set; }
        public int? GpromCero { get; set; }
        public int Gaprobado { get; set; }
        public int Data { get; set; }
        public string Aluno { get; set; }
        public string Disciplina { get; set; }
        public int Vale { get; set; }
    }
}
