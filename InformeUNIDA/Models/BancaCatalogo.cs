using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaCatalogo
    {
        public BancaCatalogo()
        {
            BancaCatalogoTarifas = new HashSet<BancaCatalogoTarifa>();
        }

        public int Ccatalogo { get; set; }
        public string Dcatalogo { get; set; }
        public string Scatalogo { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual ICollection<BancaCatalogoTarifa> BancaCatalogoTarifas { get; set; }
    }
}
