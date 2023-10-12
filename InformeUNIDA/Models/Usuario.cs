using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Usuario
    {
        public Usuario()
        {
            FuncionarioWebs = new HashSet<FuncionarioWeb>();
            Permisos = new HashSet<Permiso>();
            UsuarioAplicacions = new HashSet<UsuarioAplicacion>();
            UsuarioGrupos = new HashSet<UsuarioGrupo>();
        }

        public short Cinstitucion { get; set; }
        public short Cusuario { get; set; }
        public short CusuarioSql { get; set; }
        public string UsuarioWin { get; set; }
        public string Dusuario { get; set; }
        public string Susuario { get; set; }
        public string Tclave { get; set; }
        public short Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? CinstitucionUlt { get; set; }
        public int? CprogramaUltimo { get; set; }
        public short? CperiodoUltimo { get; set; }
        public string Tcorreo { get; set; }
        public DateTime? FcambioClave { get; set; }
        public short Naccesos { get; set; }
        public string Grecord { get; set; }
        public short? Clocal { get; set; }
        public string Gexportar { get; set; }
        public int? Corige { get; set; }
        public string Ccremp { get; set; }
        public int? Cpersona { get; set; }
        public string Ctraba { get; set; }
        public string TclaveDes { get; set; }
        public string Gplataforma { get; set; }
        public int? Carea { get; set; }
        public int? Web { get; set; }

        public virtual Persona CpersonaNavigation { get; set; }
        public virtual UsuarioSql CusuarioSqlNavigation { get; set; }
        public virtual UsuarioFirma UsuarioFirma { get; set; }
        public virtual UsuarioModuloCred UsuarioModuloCred { get; set; }
        public virtual ICollection<FuncionarioWeb> FuncionarioWebs { get; set; }
        public virtual ICollection<Permiso> Permisos { get; set; }
        public virtual ICollection<UsuarioAplicacion> UsuarioAplicacions { get; set; }
        public virtual ICollection<UsuarioGrupo> UsuarioGrupos { get; set; }
    }
}
