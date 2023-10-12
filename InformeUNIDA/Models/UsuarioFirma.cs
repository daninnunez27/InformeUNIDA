using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class UsuarioFirma
    {
        public short Cusuario { get; set; }
        public string Dfirma { get; set; }
        public string Dcargo { get; set; }
        public int? Clocal { get; set; }

        public virtual Usuario CusuarioNavigation { get; set; }
    }
}
