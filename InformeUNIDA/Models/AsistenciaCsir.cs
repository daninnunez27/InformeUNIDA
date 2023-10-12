using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AsistenciaCsir
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Ccarrera { get; set; }
        public short Gseccion { get; set; }
        public short Gbimestre { get; set; }
        public int? Calumno { get; set; }
        public DateTime? Fasistencia { get; set; }
        public short? Gasistencia { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Ninasjus { get; set; }
        public short? Ninasinjus { get; set; }
        public short? Ntardanza { get; set; }
        public short? NtardanzaInjus { get; set; }
    }
}
