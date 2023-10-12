using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Henvba00
    {
        public int Nmovim { get; set; }
        public int Nenvio { get; set; }
        public DateTime Fenvio { get; set; }
        public string Cempre { get; set; }
        public int? Ncuota { get; set; }
        public int? Nbanco { get; set; }
        public decimal? Imoras { get; set; }
        public decimal? Igasto { get; set; }
        public string Cmnpag { get; set; }
        public decimal? Idcpag { get; set; }
        public DateTime? Fpagos { get; set; }
        public string Cbanco { get; set; }
        public string Cerror { get; set; }
        public string Cusuar { get; set; }
        public string Sregis { get; set; }
        public DateTime? Fregis { get; set; }
        public int? Ndcliq { get; set; }
        public string Ctpenv { get; set; }
    }
}
