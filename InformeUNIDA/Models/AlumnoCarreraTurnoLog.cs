using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoCarreraTurnoLog
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short? CcarreraNew { get; set; }
        public short? CcarreraOld { get; set; }
        public short CmodalidadNew { get; set; }
        public short CmodalidadOld { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
