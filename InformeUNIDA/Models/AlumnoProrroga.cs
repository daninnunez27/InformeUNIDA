using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoProrroga
    {
        public long Cprorroga { get; set; }
        public int? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public string Descripcion { get; set; }
        public int? Estado { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
