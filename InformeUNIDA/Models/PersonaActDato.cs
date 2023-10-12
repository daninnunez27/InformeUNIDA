using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PersonaActDato
    {
        public int Cpersona { get; set; }
        public string Tdireccion { get; set; }
        public short Cpais { get; set; }
        public short Cdepartamento { get; set; }
        public short Cprovincia { get; set; }
        public short Cdistrito { get; set; }
        public string Ntelefono1 { get; set; }
        public string Ntelefono2 { get; set; }
        public string Ntelefono3 { get; set; }
        public string Tcorreo { get; set; }
        public string Ntelefono1Trab { get; set; }
        public string Ntelefono2Trab { get; set; }
        public string Dempresa { get; set; }
        public string TdireccionEmpresa { get; set; }
        public short? CdistritoTrabajo { get; set; }
        public short? CprovinciaTrabajo { get; set; }
        public string DcargoTrabajo { get; set; }
        public string EmailTrabajo { get; set; }
        public short? CgiroNegocio { get; set; }
    }
}
