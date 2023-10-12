using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EducativoAlumno
    {
        public short Ceducativo { get; set; }
        public short Cregistro { get; set; }
        public DateTime Fregistro { get; set; }
        public short Ggrado { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string Nombre { get; set; }
        public DateTime Fnacimiento { get; set; }
        public string Tdireccion { get; set; }
        public short? Cpais { get; set; }
        public short? Cdepartamento { get; set; }
        public short? Cprovincia { get; set; }
        public short? Cdistrito { get; set; }
        public string Ntelefono1 { get; set; }
        public string Ntelefono2 { get; set; }
        public string Nfax { get; set; }
        public string Tcorreo { get; set; }
        public short? Ccarrera1 { get; set; }
        public short? Ccarrera2 { get; set; }
        public short? Ccarrera3 { get; set; }
        public short Gestado { get; set; }
    }
}
