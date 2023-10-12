using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class UsuarioH
    {
        public short Cinstitucion { get; set; }
        public short? Cusuario { get; set; }
        public short? CusuarioSql { get; set; }
        public string Dusuario { get; set; }
        public string Susuario { get; set; }
        public string Tclave { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? CinstitucionUlt { get; set; }
        public int? CprogramaUltimo { get; set; }
        public short? CperiodoUltimo { get; set; }
        public string Tcorreo { get; set; }
        public DateTime? FcambioClave { get; set; }
        public short? Naccesos { get; set; }
        public string Grecord { get; set; }
        public short? Clocal { get; set; }
        public string Gexportar { get; set; }
        public string Corige { get; set; }
        public string Ccremp { get; set; }
        public int? Cpersona { get; set; }
        public string Ctraba { get; set; }
    }
}
