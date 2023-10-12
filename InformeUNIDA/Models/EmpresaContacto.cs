using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EmpresaContacto
    {
        public short Cempresa { get; set; }
        public short Ccontacto { get; set; }
        public string Apellidos { get; set; }
        public string ApeMaterno { get; set; }
        public string Nombres { get; set; }
        public string Dcargo { get; set; }
        public string Temail { get; set; }
        public string Datencion { get; set; }
        public int? Gresponsable { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
