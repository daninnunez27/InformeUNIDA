using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class UsuarioAplicacion
    {
        public short Cusuario { get; set; }
        public short Caplicacion { get; set; }
        public short? Gestado { get; set; }
        public short? CinstitucionUlt { get; set; }
        public int? CprogramaUltimo { get; set; }
        public short? CperiodoUltimo { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual Aplicacion CaplicacionNavigation { get; set; }
        public virtual Usuario CusuarioNavigation { get; set; }
    }
}
