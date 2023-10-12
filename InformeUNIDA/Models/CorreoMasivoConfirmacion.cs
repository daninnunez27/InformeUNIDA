using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CorreoMasivoConfirmacion
    {
        public int? Ncorreo { get; set; }
        public int? Calumno { get; set; }
        public string Gconfirmacion { get; set; }
        public byte? GtipoConfirmacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
