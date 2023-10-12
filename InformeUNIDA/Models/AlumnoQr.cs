using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AlumnoQr
    {
        public int Calumno { get; set; }
        public byte[] Qr { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Estado { get; set; }
    }
}
