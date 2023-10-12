using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class RequerimientoFlujoH
    {
        public int Ninterno { get; set; }
        public int Nrequerimiento { get; set; }
        public int Nviaje { get; set; }
        public int Calumno { get; set; }
        public int Crecepcion { get; set; }
        public int Carea { get; set; }
        public DateTime Frecepcion { get; set; }
        public DateTime? Fentrega { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Tipo { get; set; }
        public DateTime Fauditoria { get; set; }
    }
}
