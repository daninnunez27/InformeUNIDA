using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class DeclaracionVacunaCovid
    {
        public int IdDeclaracion { get; set; }
        public int? Cpersona { get; set; }
        public int? CantDosis { get; set; }
        public string TipoDosis { get; set; }
        public byte[] CertificadoFrente { get; set; }
        public string TcertificadoFrente { get; set; }
        public byte[] CertificadoPosterior { get; set; }
        public string TcertificadoPosterior { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Estado { get; set; }
    }
}
