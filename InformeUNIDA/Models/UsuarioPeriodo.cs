using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class UsuarioPeriodo
    {
        public int Cusuario { get; set; }
        public int Cperiodo { get; set; }
        public int? MostrarPrimeraLinea { get; set; }
        public int? MostrarTodasLineas { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
