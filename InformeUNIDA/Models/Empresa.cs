using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Empresa
    {
        public short Cempresa { get; set; }
        public string Dempresa { get; set; }
        public string Drazonsocial { get; set; }
        public short? Cpais { get; set; }
        public short? Cdepartamento { get; set; }
        public short? Cprovincia { get; set; }
        public short? Cdistrito { get; set; }
        public string Durbanizacion { get; set; }
        public string Tdireccion { get; set; }
        public string Nruc { get; set; }
        public string Ntelefono1 { get; set; }
        public string Ntelefono2 { get; set; }
        public string Ntelefono3 { get; set; }
        public string Nfax { get; set; }
        public short? Gsector { get; set; }
        public short? Ggiro { get; set; }
        public short? Nranking { get; set; }
        public string Dpostal { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Temail { get; set; }
        public string Twww { get; set; }
    }
}
