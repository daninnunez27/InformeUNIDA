﻿using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Persona
    {
        public Persona()
        {
            AlumnoPeriodos = new HashSet<AlumnoPeriodo>();
            Alumnos = new HashSet<Alumno>();
            Especialista = new HashSet<Especialistum>();
            Pacientes = new HashSet<Paciente>();
            PersonaActualizacions = new HashSet<PersonaActualizacion>();
            PersonaCongresos = new HashSet<PersonaCongreso>();
            PersonaExperiencia = new HashSet<PersonaExperiencium>();
            PersonaIdiomas = new HashSet<PersonaIdioma>();
            PersonaInvestigacions = new HashSet<PersonaInvestigacion>();
            PersonaMencions = new HashSet<PersonaMencion>();
            PersonaPosgrados = new HashSet<PersonaPosgrado>();
            PersonaPublicacions = new HashSet<PersonaPublicacion>();
            PersonaTesis = new HashSet<PersonaTesi>();
            PersonaTitulos = new HashSet<PersonaTitulo>();
            PersonaTrabajos = new HashSet<PersonaTrabajo>();
            Profesors = new HashSet<Profesor>();
            Usuarios = new HashSet<Usuario>();
        }

        public int Cpersona { get; set; }
        public string ApePaterno { get; set; }
        public string ApeMaterno { get; set; }
        public string ApeConyuge { get; set; }
        public string Nombre { get; set; }
        public string Spersona { get; set; }
        public string Dpersona { get; set; }
        public int? Gdireccion { get; set; }
        public string Tdireccion { get; set; }
        public short? Cpais { get; set; }
        public short? Cdepartamento { get; set; }
        public short? Cprovincia { get; set; }
        public short? Cdistrito { get; set; }
        public string Ntelefono1 { get; set; }
        public string Ntelefono2 { get; set; }
        public DateTime? Fnacimiento { get; set; }
        public string Sexo { get; set; }
        public string LibElectoral { get; set; }
        public string LibMilitar { get; set; }
        public int? GdocIdentidad { get; set; }
        public string NdocIdentidad { get; set; }
        public DateTime? FdocExpedido { get; set; }
        public short? Gestadocivil { get; set; }
        public short? Gprofesion { get; set; }
        public string Cipss { get; set; }
        public string Cafp { get; set; }
        public short? Gsangre { get; set; }
        public string TclaveSil { get; set; }
        public string Ttrabajo { get; set; }
        public string TdireccionTrab { get; set; }
        public short? CpaisTrab { get; set; }
        public short? CdepartamentoTrab { get; set; }
        public short? CprovinciaTrab { get; set; }
        public short? CdistritoTrab { get; set; }
        public string Tcargo { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Gvivienda { get; set; }
        public short? Gvive { get; set; }
        public short? CpaisNac { get; set; }
        public short? CdepartamentoNac { get; set; }
        public short? CprovinciaNac { get; set; }
        public short? CdistritoNac { get; set; }
        public short? Gingles { get; set; }
        public short? GempCelular { get; set; }
        public short? Gestado { get; set; }
        public string Tobservacion { get; set; }
        public string TgiroTrab { get; set; }
        public string Ntelefono1Trab { get; set; }
        public string Ntelefono2Trab { get; set; }
        public string Tcorreo { get; set; }
        public string Tcorreo2 { get; set; }
        public short? GmonedaPension { get; set; }
        public short? GbecaColegio { get; set; }
        public short? GbecaMotivo { get; set; }
        public decimal? NpensionColegio { get; set; }
        public decimal? NbecaPorcentaje { get; set; }
        public short? GestadoCivilPer { get; set; }
        public short? GestadoCivilPad { get; set; }
        public short? GestadoCivilMad { get; set; }
        public short? GgradoInstrucMad { get; set; }
        public short? GgradoInstrucPad { get; set; }
        public short? GgradoInstrucPer { get; set; }
        public short? GsituacionLabMad { get; set; }
        public short? GsituacionLabPad { get; set; }
        public short? GsituacionLabPer { get; set; }
        public short? GviveCon { get; set; }
        public short? NedadPadre { get; set; }
        public short? NedadMadre { get; set; }
        public short? GtipoVivienda { get; set; }
        public short? GcondicionVivien { get; set; }
        public short? GviviendaProv { get; set; }
        public short? GcondVivienProv { get; set; }
        public short? GmonedaIngreso { get; set; }
        public decimal? NingresoPersona { get; set; }
        public decimal? NingresoPadre { get; set; }
        public decimal? NingresoMadre { get; set; }
        public short? GmonedaEgreso { get; set; }
        public decimal? NegresoFamiliar { get; set; }
        public string Tempresa { get; set; }
        public short? GgiroEmpresa { get; set; }
        public short? Cnacionalidad { get; set; }
        public short? GnivelEstudio { get; set; }
        public short? Nhijo { get; set; }
        public string Ntelefono3 { get; set; }
        public string TcorreoSil { get; set; }
        public string TcorreoTrabajo { get; set; }
        public string GreferenciaDireccion { get; set; }
        public string Tprofesion { get; set; }
        public string Tclubes { get; set; }
        public string Turbanizacion { get; set; }
        public int? Ceducativo { get; set; }
        public int? Ceducativo2 { get; set; }
        public string DpersonaOriginal { get; set; }
        public int? Ncalle { get; set; }
        public string TcorreoLive { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string UModificacionClaveEclass { get; set; }
        public DateTime? FModificacionClaveEclass { get; set; }
        public DateTime? FUltimoAcceso { get; set; }
        public string NroAseguradoIps { get; set; }
        public string CategoriaIps { get; set; }
        public string UModificacionIps { get; set; }
        public DateTime? FModificacionIps { get; set; }
        public string Alergia { get; set; }
        public string Gsanguineo { get; set; }
        public int? UModificacionEclass { get; set; }
        public DateTime? FModificacionEclass { get; set; }

        public virtual Foto Foto { get; set; }
        public virtual ICollection<AlumnoPeriodo> AlumnoPeriodos { get; set; }
        public virtual ICollection<Alumno> Alumnos { get; set; }
        public virtual ICollection<Especialistum> Especialista { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
        public virtual ICollection<PersonaActualizacion> PersonaActualizacions { get; set; }
        public virtual ICollection<PersonaCongreso> PersonaCongresos { get; set; }
        public virtual ICollection<PersonaExperiencium> PersonaExperiencia { get; set; }
        public virtual ICollection<PersonaIdioma> PersonaIdiomas { get; set; }
        public virtual ICollection<PersonaInvestigacion> PersonaInvestigacions { get; set; }
        public virtual ICollection<PersonaMencion> PersonaMencions { get; set; }
        public virtual ICollection<PersonaPosgrado> PersonaPosgrados { get; set; }
        public virtual ICollection<PersonaPublicacion> PersonaPublicacions { get; set; }
        public virtual ICollection<PersonaTesi> PersonaTesis { get; set; }
        public virtual ICollection<PersonaTitulo> PersonaTitulos { get; set; }
        public virtual ICollection<PersonaTrabajo> PersonaTrabajos { get; set; }
        public virtual ICollection<Profesor> Profesors { get; set; }
        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
