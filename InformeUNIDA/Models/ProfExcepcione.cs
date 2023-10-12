using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfExcepcione
    {
        public int Cid { get; set; }
        public int? Copcion { get; set; }
        public int? Caplicacion { get; set; }
        public short? Cusuario { get; set; }
        public DateTime? Fparametro01 { get; set; }
        public DateTime? Fparametro02 { get; set; }
        public DateTime? Fparametro03 { get; set; }
        public int? Iparametro04 { get; set; }
        public int? Iparametro05 { get; set; }
        public int? Iparametro06 { get; set; }
        public short? Siparametro07 { get; set; }
        public short? Siparametro08 { get; set; }
        public short? Siparametro09 { get; set; }
        public string Vcparametro10 { get; set; }
        public string Vcparametro11 { get; set; }
        public string Vcparametro12 { get; set; }
        public short? Gestado { get; set; }
        public short? Cusuariocrea { get; set; }
        public DateTime? Fcreacion { get; set; }
        public short? Cusuariomod { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
