using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoIncluyeWeb
    {
        public int? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public int? Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public DateTime? Fproceso { get; set; }
        public int? Ntransaccion { get; set; }
        public string Gestado { get; set; }
        public int? Cobligacion { get; set; }
    }
}
