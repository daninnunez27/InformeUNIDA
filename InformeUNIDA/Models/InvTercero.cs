using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class InvTercero
    {
        public short Ctercero { get; set; }
        public string Dtercero { get; set; }
        public string Stercero { get; set; }
        public short? Carea { get; set; }
        public short? Clocal { get; set; }
        public short Gtipo { get; set; }
        public string Tobservacion { get; set; }
        public short? Gestado { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Cmodificacion { get; set; }
    }
}
