using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class LibroReclamoWeb
    {
        public int? Cinstitucion { get; set; }
        public int IdReclamo { get; set; }
        public string Nombreyapellido { get; set; }
        public string Cingreso { get; set; }
        public string Correo { get; set; }
        public string Ntelefono { get; set; }
        public int? Treclamo { get; set; }
        public string DReclamo { get; set; }
        public byte[] Archivo { get; set; }
        public string Tarchivo { get; set; }
        public string Ip { get; set; }
        public DateTime? Fcreacion { get; set; }
    }
}
