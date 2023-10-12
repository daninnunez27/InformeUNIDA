using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class FuncionarioWebPermiso
    {
        public int Idpermiso { get; set; }
        public int? Cusuario { get; set; }
        public string LugarPermiso { get; set; }
        public string ItemPermiso { get; set; }
        public int? Estado { get; set; }
    }
}
