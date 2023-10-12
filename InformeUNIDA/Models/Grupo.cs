using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Grupo
    {
        public Grupo()
        {
            UsuarioGrupos = new HashSet<UsuarioGrupo>();
        }

        public short Cgrupo { get; set; }
        public string Dgrupo { get; set; }
        public string Sgrupo { get; set; }
        public short Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }

        public virtual ICollection<UsuarioGrupo> UsuarioGrupos { get; set; }
    }
}
