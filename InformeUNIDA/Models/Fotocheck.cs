using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Fotocheck
    {
        public short GtipoEnte { get; set; }
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short? Cevaluacion { get; set; }
        public string Tmodelo { get; set; }
        public string Tobjeto { get; set; }
        public DateTime? Fvencimiento { get; set; }
        public short Gestado { get; set; }
        public short? GtipoFotocheck { get; set; }
    }
}
