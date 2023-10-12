using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CostosParamPlaac
    {
        public int Nano { get; set; }
        public int Nmes { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public DateTime Finiplan { get; set; }
        public DateTime Ffinplan { get; set; }
        public int Nevolucion { get; set; }
        public string Cempre { get; set; }
        public int CgeneradoPras { get; set; }
        public DateTime Fgenerado { get; set; }
    }
}
