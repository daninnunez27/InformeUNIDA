using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Profesor
    {
        public Profesor()
        {
            BloqueSesions = new HashSet<BloqueSesion>();
            CursoCoordinadors = new HashSet<CursoCoordinador>();
        }

        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cprofesor { get; set; }
        public int Cpersona { get; set; }
        public short? Gcondicion { get; set; }
        public short? Gcategoria { get; set; }
        public short? Gregimen { get; set; }
        public string Ccodtra { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Tclave { get; set; }
        public string Cingreso { get; set; }
        public string Tcorreo { get; set; }
        public string GasistenciaInfosil { get; set; }
        public string Tbancaria { get; set; }
        public string GtipoPlanilla { get; set; }
        public short? FlagProcesar { get; set; }
        public string UrlConferencia { get; set; }
        public short? Escalafon { get; set; }

        public virtual Persona CpersonaNavigation { get; set; }
        public virtual ICollection<BloqueSesion> BloqueSesions { get; set; }
        public virtual ICollection<CursoCoordinador> CursoCoordinadors { get; set; }
    }
}
