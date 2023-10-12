using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoMerito
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short Gbimestre { get; set; }
        public decimal? Npuntaje { get; set; }
        public decimal? Npromedio { get; set; }
        public short? Nmerito { get; set; }
        public short? Nparticipan { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
