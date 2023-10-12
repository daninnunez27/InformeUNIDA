using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Modulo
    {
        public Modulo()
        {
            Permisos = new HashSet<Permiso>();
        }

        public short Caplicacion { get; set; }
        public short Cmodulo { get; set; }
        public string Dmodulo { get; set; }
        public string Tobjeto { get; set; }
        public short Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Ipublico { get; set; }
        public short? GtipoModulo { get; set; }
        public string GclaseModulo { get; set; }
        public short? Nconcurrencia { get; set; }

        public virtual ICollection<Permiso> Permisos { get; set; }
    }
}
