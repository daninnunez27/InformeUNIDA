using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Clasificacion
    {
        public Clasificacion()
        {
            BibReservas = new HashSet<BibReserva>();
            Datos = new HashSet<Dato>();
            Indice = new HashSet<Indie>();
            Objetos = new HashSet<Objeto>();
        }

        public int Cclasificacion { get; set; }
        public string Dclasificacion { get; set; }
        public string DclasificacionSub { get; set; }
        public string Sclasificacion { get; set; }
        public int Gdominio { get; set; }
        public int Cestructura { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? CclasificacionPadre { get; set; }
        public int Gsubdominio { get; set; }

        public virtual Estructura CestructuraNavigation { get; set; }
        public virtual ICollection<BibReserva> BibReservas { get; set; }
        public virtual ICollection<Dato> Datos { get; set; }
        public virtual ICollection<Indie> Indice { get; set; }
        public virtual ICollection<Objeto> Objetos { get; set; }
    }
}
