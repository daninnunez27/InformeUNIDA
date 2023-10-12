using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BancaTarifa
    {
        public BancaTarifa()
        {
            BancaCatalogoTarifas = new HashSet<BancaCatalogoTarifa>();
            BancaTarifaPrecios = new HashSet<BancaTarifaPrecio>();
        }

        public int Ctarifa { get; set; }
        public string Dtarifa { get; set; }
        public string Starifa { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual ICollection<BancaCatalogoTarifa> BancaCatalogoTarifas { get; set; }
        public virtual ICollection<BancaTarifaPrecio> BancaTarifaPrecios { get; set; }
    }
}
