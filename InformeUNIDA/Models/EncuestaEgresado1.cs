using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EncuestaEgresado1
    {
        public EncuestaEgresado1()
        {
            EncuestaDeslaborals = new HashSet<EncuestaDeslaboral>();
            EncuestaMotivosInsatisfaccions = new HashSet<EncuestaMotivosInsatisfaccion>();
            EncuestaTitulosPostgrados = new HashSet<EncuestaTitulosPostgrado>();
        }

        public int Cencuesta { get; set; }
        public DateTime Fencuesta { get; set; }
        public int Ccarrera { get; set; }
        public int Cprograma { get; set; }
        public string Cingreso { get; set; }
        public int? Aingreso { get; set; }
        public int? Aegreso { get; set; }
        public string Dpersona { get; set; }
        public int GdocIdentidad { get; set; }
        public string NdocIdentidad { get; set; }
        public string Tdireccion { get; set; }
        public int? Ndireccion { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public string Ntelefono { get; set; }
        public string Tcorreo { get; set; }
        public DateTime Fnacimiento { get; set; }
        public string DepNacimiento { get; set; }
        public int? Sexo { get; set; }
        public int? GestadoCivil { get; set; }
        public int? Cnacionalidad { get; set; }
        public string Dnacionalidad { get; set; }
        public int? GconEstudios { get; set; }
        public int? GsegEstudiando { get; set; }
        public int? GsegEstudiando2 { get; set; }
        public int? TrabActualmente { get; set; }
        public int? CantCargos { get; set; }
        public int? TipoOcupaActual { get; set; }
        public string DtipoOcupaActual { get; set; }
        public int? NivSalario { get; set; }
        public int? FunProfesion { get; set; }
        public int? CausaNoTrabaja { get; set; }
        public string DcausaNoTrabaja { get; set; }
        public int PrepCarrera { get; set; }
        public int? PertinenciaCursos { get; set; }
        public int? Aspectos { get; set; }
        public string Daspectos { get; set; }
        public int? ExtensionUniv { get; set; }
        public int? TipoExtension { get; set; }
        public string DtipoExtension { get; set; }
        public int? Contribuye { get; set; }
        public int? ActInvestigacion { get; set; }
        public string DactInvestigacion { get; set; }
        public int? ContribuyeAct { get; set; }
        public int? DificIniciarse { get; set; }
        public int? NdificIniciarse { get; set; }
        public string DdificIniciarse { get; set; }
        public int? FacPlanEstudio { get; set; }
        public int? IntPostgrado { get; set; }
        public int? NivPostgrado { get; set; }
        public string AreaPostgrado { get; set; }
        public string Sugerencias { get; set; }

        public virtual ICollection<EncuestaDeslaboral> EncuestaDeslaborals { get; set; }
        public virtual ICollection<EncuestaMotivosInsatisfaccion> EncuestaMotivosInsatisfaccions { get; set; }
        public virtual ICollection<EncuestaTitulosPostgrado> EncuestaTitulosPostgrados { get; set; }
    }
}
