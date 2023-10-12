using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class UsuarioModuloCred
    {
        public short Cusuario { get; set; }
        public short Cmodulo { get; set; }
        public short CtipoCliente { get; set; }

        public virtual Usuario CusuarioNavigation { get; set; }
    }
}
