using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class UsuarioPrograma
    {
        public short Cusuario { get; set; }
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short GclasePeriodo { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Gestado { get; set; }

        public virtual Programa CprogramaNavigation { get; set; }
        public virtual Usuario CusuarioNavigation { get; set; }
    }
}
