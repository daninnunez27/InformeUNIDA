using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Modalidad
    {
        public Modalidad()
        {
            AlumnoPeriodos = new HashSet<AlumnoPeriodo>();
            CarreraModalidads = new HashSet<CarreraModalidad>();
        }

        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cmodalidad { get; set; }
        public string Dmodalidad { get; set; }
        public string Smodalidad { get; set; }
        public short? NcursoPromPerio { get; set; }
        public short? NcredPromPerio { get; set; }

        public virtual ICollection<AlumnoPeriodo> AlumnoPeriodos { get; set; }
        public virtual ICollection<CarreraModalidad> CarreraModalidads { get; set; }
    }
}
