using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BdContacto
    {
        public int? Cactividad { get; set; }
        public int? CtipoActividad { get; set; }
        public int? Cpersona { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string PersonaDpersona { get; set; }
        public string Dcontacto { get; set; }
        public string Dcarrera1 { get; set; }
        public string Dcarrera2 { get; set; }
        public string Ntelefono1 { get; set; }
        public string Ntelefono2 { get; set; }
        public string Ntelefono3 { get; set; }
        public string Dactividad { get; set; }
        public int? Cevento { get; set; }
        public int? Cadmision { get; set; }
        public string PersonaTcorreo { get; set; }
        public string Drespuesta { get; set; }
        public string Dsubrespuesta { get; set; }
        public DateTime? Fgestion { get; set; }
        public string Dglosa { get; set; }
        public string Crespuesta { get; set; }
        public string Csubrespuesta { get; set; }
        public DateTime? Finscripcion { get; set; }
        public DateTime? Fprocesa1 { get; set; }
        public DateTime? Fprocesa2 { get; set; }
        public DateTime? Fregistro { get; set; }
        public int? CmedioContacto { get; set; }
    }
}
