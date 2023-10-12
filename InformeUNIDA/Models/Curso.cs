using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Curso
    {
        public Curso()
        {
            BloqueCursos = new HashSet<BloqueCurso>();
            CurriculaCursos = new HashSet<CurriculaCurso>();
            EquivalenciumCcursoEquivNavigations = new HashSet<Equivalencium>();
            EquivalenciumCcursoNavigations = new HashSet<Equivalencium>();
            Fichas = new HashSet<Ficha>();
        }

        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Ccurso { get; set; }
        public short? Gtipocurso { get; set; }
        public int? Careaconocimiento { get; set; }
        public short Cdepartamento { get; set; }
        public short Carea { get; set; }
        public string DcursoU { get; set; }
        public string ScursoU { get; set; }
        public string DcursoCertificadoU { get; set; }
        public short? NcreditoU { get; set; }
        public short? NcreditoRealU { get; set; }
        public short? NteoriaU { get; set; }
        public short? NpracticaU { get; set; }
        public short? NlaboratorioU { get; set; }
        public short GcobraU { get; set; }
        public decimal? PorcInasistenciaU { get; set; }
        public short? GinasistenciaU { get; set; }
        public short? NvezMaximaU { get; set; }
        public short? NfamiliaU { get; set; }
        public short? NcadenaU { get; set; }
        public short? GtipoCreditoU { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string GtieneHorario { get; set; }
        public string Dcurso { get; set; }
        public string Scurso { get; set; }
        public string DcursoCertificado { get; set; }
        public short? Ncredito { get; set; }
        public short? NcreditoReal { get; set; }
        public short? Nteoria { get; set; }
        public short? Npractica { get; set; }
        public short? Nlaboratorio { get; set; }
        public short Gcobra { get; set; }
        public decimal? PorcInasistencia { get; set; }
        public short? Ginasistencia { get; set; }
        public short? NvezMaxima { get; set; }
        public short? Nfamilia { get; set; }
        public short? Ncadena { get; set; }
        public short? GtipoCredito { get; set; }
        public string Silabo { get; set; }
        public string PlantillaCurso { get; set; }

        public virtual ICollection<BloqueCurso> BloqueCursos { get; set; }
        public virtual ICollection<CurriculaCurso> CurriculaCursos { get; set; }
        public virtual ICollection<Equivalencium> EquivalenciumCcursoEquivNavigations { get; set; }
        public virtual ICollection<Equivalencium> EquivalenciumCcursoNavigations { get; set; }
        public virtual ICollection<Ficha> Fichas { get; set; }
    }
}
