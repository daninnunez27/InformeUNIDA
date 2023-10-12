using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Local
    {
        public short Clocal { get; set; }
        public string Dlocal { get; set; }
        public string Slocal { get; set; }
        public string Tdireccion { get; set; }
        public short? Cpais { get; set; }
        public short? Cdepartamento { get; set; }
        public short? Cprovincia { get; set; }
        public short? Cdistrito { get; set; }
        public short? Gtipo { get; set; }
        public string Ntelefono1 { get; set; }
        public string Ntelefono2 { get; set; }
        public string Ntelefono3 { get; set; }
        public string Nfax { get; set; }
        public short? Gcondicion { get; set; }
        public short? Gestado { get; set; }
        public string Corige { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
