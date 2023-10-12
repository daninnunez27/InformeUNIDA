using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class DocumCompaniaPer
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public short? Cdocumento { get; set; }
        public short? Norden { get; set; }
        public DateTime? Flimite { get; set; }
        public short? Gdocumento { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Nsesion { get; set; }
    }
}
