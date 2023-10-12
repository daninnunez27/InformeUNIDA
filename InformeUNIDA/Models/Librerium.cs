using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Librerium
    {
        public short Caplicacion { get; set; }
        public short Clibreria { get; set; }
        public string Dlibreria { get; set; }
        public string Tobjeto { get; set; }
        public short Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
