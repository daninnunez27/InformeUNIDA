using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Carrera
    {
        public Carrera()
        {
            AlumnoPeriodos = new HashSet<AlumnoPeriodo>();
            CarreraModalidads = new HashSet<CarreraModalidad>();
            Especialidads = new HashSet<Especialidad>();
        }

        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cfacultad { get; set; }
        public short Ccarrera { get; set; }
        public string Dcarrera { get; set; }
        public string Scarrera { get; set; }
        public short? Nciclo { get; set; }
        public short Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short CcarreraEquiv { get; set; }
        public int? Norden { get; set; }
        public string Dtitulo { get; set; }
        public string Sigla { get; set; }
        public string Dcarrerapostgrado { get; set; }
        public string Resolucion { get; set; }
        public string Aprobadopor { get; set; }
        public short? Gvisible { get; set; }
        public string DcarreraImprenta { get; set; }
        public int? EstadoTesis { get; set; }

        public virtual Facultad CfacultadNavigation { get; set; }
        public virtual ICollection<AlumnoPeriodo> AlumnoPeriodos { get; set; }
        public virtual ICollection<CarreraModalidad> CarreraModalidads { get; set; }
        public virtual ICollection<Especialidad> Especialidads { get; set; }
    }
}
