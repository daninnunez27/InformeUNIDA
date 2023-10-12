using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoParaAcadH
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short Gcategoria { get; set; }
        public short Ccredito { get; set; }
        public short Ncantidad { get; set; }
        public byte? GtipoCantidad { get; set; }
        public short? Gtipo { get; set; }
        public string Dglosa { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
