using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Opcione
    {
        public int Cid { get; set; }
        public int? OpcicCod { get; set; }
        public int? AplicCod { get; set; }
        public string OpcicDes { get; set; }
        public string OpcicAbrev { get; set; }
        public int? OpcicCodpad { get; set; }
        public short? EstacCod { get; set; }
        public int? OpcicNiv { get; set; }
        public int? OpcicNivPad { get; set; }
        public string OpcicObs { get; set; }
        public string OpcicNompag { get; set; }
        public int? OpcicFlamen { get; set; }
        public int? OpcicNumord { get; set; }
        public int? OpcicD1 { get; set; }
        public string UsuCrea { get; set; }
        public DateTime? FechCrea { get; set; }
        public string UsuMod { get; set; }
        public DateTime? FechMod { get; set; }
        public string Usuario { get; set; }
    }
}
