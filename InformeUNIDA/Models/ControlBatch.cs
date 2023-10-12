using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ControlBatch
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public string Cperiodo { get; set; }
        public short Nregistros { get; set; }
        public DateTime Finicio { get; set; }
        public DateTime Ffinal { get; set; }
    }
}
