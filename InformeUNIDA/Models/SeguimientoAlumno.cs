using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SeguimientoAlumno
    {
        public int Cperiodo { get; set; }
        public int Ccarrera { get; set; }
        public int Calumno { get; set; }
        public int Ccurso { get; set; }
        public string Accion1 { get; set; }
        public string Accion2 { get; set; }
        public string Accion3 { get; set; }
        public string Ucreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Umodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
