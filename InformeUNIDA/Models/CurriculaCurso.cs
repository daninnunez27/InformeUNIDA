using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CurriculaCurso
    {
        public CurriculaCurso()
        {
            Prerequisitos = new HashSet<Prerequisito>();
        }

        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Ccurricula { get; set; }
        public short Ccurso { get; set; }
        public short? Nciclo { get; set; }
        public decimal? NcreditoMinimo { get; set; }
        public short? Gcondicion { get; set; }
        public short? Gestado { get; set; }
        public short? Ncadena { get; set; }
        public short? Norden { get; set; }
        public string Dcurso { get; set; }
        public string Scurso { get; set; }
        public string DcursoCertificado { get; set; }
        public short? Ncredito { get; set; }
        public short? NcreditoReal { get; set; }
        public short? Nteoria { get; set; }
        public short? Npractica { get; set; }
        public short? Nlaboratorio { get; set; }
        public short? Gcobra { get; set; }
        public decimal? PorcInasistencia { get; set; }
        public short? Ginasistencia { get; set; }
        public short? NvezMaxima { get; set; }
        public short? Nfamilia { get; set; }
        public short? GtipoCredito { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Gtipo { get; set; }
        public string Silabo { get; set; }

        public virtual Curriculum CcurriculaNavigation { get; set; }
        public virtual Curso CcursoNavigation { get; set; }
        public virtual ICollection<Prerequisito> Prerequisitos { get; set; }
    }
}
