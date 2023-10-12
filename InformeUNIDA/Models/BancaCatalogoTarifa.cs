using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaCatalogoTarifa
    {
        public int Ccatalogo { get; set; }
        public int Ctarifa { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual BancaCatalogo CcatalogoNavigation { get; set; }
        public virtual BancaTarifa CtarifaNavigation { get; set; }
    }
}
