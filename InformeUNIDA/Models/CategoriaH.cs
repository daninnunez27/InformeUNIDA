using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CategoriaH
    {
        public short CgrupoCatProf { get; set; }
        public string Tcategoria { get; set; }
        public string Tglosa { get; set; }
        public string Cmoneda { get; set; }
        public decimal Itarifa { get; set; }
        public string CmonedaRef { get; set; }
        public decimal? ItarifaRef { get; set; }
        public decimal Iremuneracion { get; set; }
        public decimal I6toGratiOrd { get; set; }
        public decimal IbonifTransp { get; set; }
        public decimal Irefrigerio { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
    }
}
