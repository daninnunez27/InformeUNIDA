﻿using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BibReserva
    {
        public int Creserva { get; set; }
        public int? Cclasificacion { get; set; }
        public DateTime? Fhinicio { get; set; }
        public DateTime? Fhfin { get; set; }
        public int? Cpersona { get; set; }
        public int? Gestado { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public DateTime? Fhexpiracion { get; set; }
        public DateTime? Fhregistro { get; set; }
        public int? Cmovimiento { get; set; }
        public int? Codalumprof { get; set; }

        public virtual Clasificacion CclasificacionNavigation { get; set; }
    }
}
