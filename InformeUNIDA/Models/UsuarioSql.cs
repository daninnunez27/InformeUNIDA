using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class UsuarioSql
    {
        public UsuarioSql()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public short CusuarioSql { get; set; }
        public string DusuarioSql { get; set; }
        public string SusuarioSql { get; set; }
        public string Tclave { get; set; }
        public short Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? NdiasLimite { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
