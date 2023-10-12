using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BloqueSesion
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Cbloque { get; set; }
        public short Ccurso { get; set; }
        public short Ndia { get; set; }
        public DateTime Hinicio { get; set; }
        public short? Cprofesor { get; set; }
        public short? Caula { get; set; }
        public DateTime Hfinal { get; set; }
        public short? GtipoHora { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Gestado { get; set; }
        public DateTime? Fdesde { get; set; }
        public DateTime? Fhasta { get; set; }
        public string GasistInfosil { get; set; }
        public string Gvirtual { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }

        public virtual Profesor CprofesorNavigation { get; set; }
    }
}
