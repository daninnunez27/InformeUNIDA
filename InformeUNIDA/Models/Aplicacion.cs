using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Aplicacion
    {
        public Aplicacion()
        {
            UsuarioAplicacions = new HashSet<UsuarioAplicacion>();
        }

        public short Caplicacion { get; set; }
        public string Daplicacion { get; set; }
        public string Saplicacion { get; set; }
        public string Tversion { get; set; }
        public short Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Tactualiza { get; set; }
        public short? Cversion { get; set; }
        public string Dini { get; set; }
        public string Ddirectorioo { get; set; }
        public string Ddirectoriop { get; set; }
        public string Ddirectoriod { get; set; }
        public string Ruta { get; set; }

        public virtual ICollection<UsuarioAplicacion> UsuarioAplicacions { get; set; }
    }
}
