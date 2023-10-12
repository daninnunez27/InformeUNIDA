using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoHolograma
    {
        public int Id { get; set; }
        public int Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public string Cholograma { get; set; }
        public int? Calumno { get; set; }
        public int? Estado { get; set; }
        public string Descripcion { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
