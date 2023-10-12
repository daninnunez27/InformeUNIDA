using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Companium
    {
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public short? Ccompania { get; set; }
        public string Scompania { get; set; }
        public string Dcompania { get; set; }
        public short? Ccarrera { get; set; }
        public int? Cprofesor { get; set; }
        public string Dproducto { get; set; }
        public string Ddireccion { get; set; }
        public short? Cpais { get; set; }
        public short? Cdepartamento { get; set; }
        public short? Cprovincia { get; set; }
        public short? Cdistrito { get; set; }
        public string Ntelefono1 { get; set; }
        public string Ntelefono2 { get; set; }
        public string Nfax { get; set; }
        public string Email { get; set; }
        public short? Nacciones { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
