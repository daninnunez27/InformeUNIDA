using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Mlgpvotante
    {
        public int Idvotante { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Cedula { get; set; }
        public string Ciudad { get; set; }
        public string Sexo { get; set; }
        public string Telefono { get; set; }
        public string Img { get; set; }
        public int? Idmlgope { get; set; }
        public string Estado { get; set; }
        public string ImgFinalizado { get; set; }
    }
}
