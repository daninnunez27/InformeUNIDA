using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class UsuarioGrupo
    {
        public short Cgrupo { get; set; }
        public short Cusuario { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Ccarrera { get; set; }

        public virtual Grupo CgrupoNavigation { get; set; }
        public virtual Usuario CusuarioNavigation { get; set; }
    }
}
