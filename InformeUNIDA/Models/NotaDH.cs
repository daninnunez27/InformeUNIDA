using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class NotaDH
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short Ccurso { get; set; }
        public short GtipoNota { get; set; }
        public decimal? NnotaAcumulado { get; set; }
        public decimal? Nnota { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Tnota { get; set; }
        public DateTime? Fdata { get; set; }
        public int? Clog { get; set; }
        public int IdCreacion { get; set; }
    }
}
