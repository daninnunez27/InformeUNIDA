using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Matricula
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public int Ntransaccion { get; set; }
        public short? Gestado { get; set; }
        public string Tmensaje { get; set; }
        public DateTime? Fregistro { get; set; }
        public DateTime? Hregistro { get; set; }
        public string Nip { get; set; }
        public short? Ccarrera { get; set; }
        public short? GtipoMatricula { get; set; }
        public DateTime? Fproceso { get; set; }
        public DateTime? Hproceso { get; set; }
        public string Cmodificacion { get; set; }
        public short? QcursosMatri { get; set; }
    }
}
