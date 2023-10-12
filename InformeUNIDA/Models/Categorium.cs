using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Categorium
    {
        public int CgrupoCatProf { get; set; }
        public string Tcategoria { get; set; }
        public string Tglosa { get; set; }
        public int Cmoneda { get; set; }
        public decimal Itarifa { get; set; }
        public int? CmonedaRef { get; set; }
        public decimal? ItarifaRef { get; set; }
        public decimal Iremuneracion { get; set; }
        public decimal I6toGratiOrd { get; set; }
        public decimal IbonifTransp { get; set; }
        public decimal Irefrigerio { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public decimal PorcIps55 { get; set; }
        public decimal PorcIps25 { get; set; }
    }
}
