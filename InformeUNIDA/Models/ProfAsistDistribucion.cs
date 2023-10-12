using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfAsistDistribucion
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short GtipoAsistencia { get; set; }
        public DateTime FinicioProg { get; set; }
        public short Cprofesor { get; set; }
        public string Ccenrp { get; set; }
        public decimal Nhoras { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
