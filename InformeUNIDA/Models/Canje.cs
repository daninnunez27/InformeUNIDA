using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Canje
    {
        public short Cinstitucion { get; set; }
        public int Codigo { get; set; }
        public DateTime? Fecha { get; set; }
        public int? Tipo { get; set; }
        public string Nro { get; set; }
        public string Persona { get; set; }
        public decimal? Monto { get; set; }
        public int? Gestado { get; set; }
        public string Ucreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Umodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
