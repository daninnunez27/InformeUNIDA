using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaCv
    {
        public int? Cpersona { get; set; }
        public byte[] Cv { get; set; }
        public int Ccv { get; set; }
        public DateTime? Fcreacion { get; set; }
    }
}
