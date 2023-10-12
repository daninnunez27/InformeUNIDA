using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Permiso
    {
        public short Cusuario { get; set; }
        public short Caplicacion { get; set; }
        public short Cmodulo { get; set; }
        public string Iagregar { get; set; }
        public string Imodificar { get; set; }
        public string Ieliminar { get; set; }
        public string Iconsultar { get; set; }
        public string Iexportar { get; set; }
        public short? Gnivel { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Iejecutar { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public string Cempre { get; set; }
        public string Cprogr { get; set; }
        public int? NselectTop { get; set; }
        public string Iordenar { get; set; }
        public string Ibuscar { get; set; }
        public string Ifiltrar { get; set; }
        public string Iimprimir { get; set; }
        public string Ipropiedaddelavista { get; set; }
        public string Iactualizar { get; set; }

        public virtual Modulo C { get; set; }
        public virtual Usuario CusuarioNavigation { get; set; }
    }
}
