﻿using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Objeto
    {
        public Objeto()
        {
            BibMovimientos = new HashSet<BibMovimiento>();
        }

        public int Cobjeto { get; set; }
        public int Cclasificacion { get; set; }
        public int CobjetoPadre { get; set; }
        public string Sobjeto { get; set; }
        public DateTime? Fhingreso { get; set; }
        public int GformaAdquisicion { get; set; }
        public string Tprocedencia { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Tobservacion { get; set; }
        public int Gdominio { get; set; }
        public int? Cmovimiento { get; set; }
        public int? Iprotegido { get; set; }
        public int? Nacceso { get; set; }
        public int Gcondicion { get; set; }

        public virtual Clasificacion CclasificacionNavigation { get; set; }
        public virtual ICollection<BibMovimiento> BibMovimientos { get; set; }
    }
}
