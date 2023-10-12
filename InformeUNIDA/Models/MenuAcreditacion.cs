using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class MenuAcreditacion
    {
        public long? Nivel1 { get; set; }
        public long? Nivel2 { get; set; }
        public long? Nivel3 { get; set; }
        public long? Nivel4 { get; set; }
        public long? Nivel5 { get; set; }
        public long? Nivel6 { get; set; }
        public long? Nivel7 { get; set; }
        public long? Nivel { get; set; }
        public string Descripcion { get; set; }
        public long? Pictureindex { get; set; }
        public long? Selectedpictureindex { get; set; }
        public long Id { get; set; }
        public long? Pid { get; set; }
        public long? Orden { get; set; }
        public string Titulo { get; set; }
        public string Resumen { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
