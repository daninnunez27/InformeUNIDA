using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class Contacto
    {
        public int Ncontacto { get; set; }
        public string Tnombre { get; set; }
        public string Tcorreo { get; set; }
        public string Ntelefono1 { get; set; }
        public string Ntelefono2 { get; set; }
        public int? Ccarrera1 { get; set; }
        public int Gcontacto { get; set; }
        public int Tipo { get; set; }
        public int? Cpersona { get; set; }
        public int? Cpostulante { get; set; }
        public int? Calumno { get; set; }
        public int? Cperiodo { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Tedad { get; set; }
        public string Tsexo { get; set; }
        public string Tturno { get; set; }
        public string Tconsulta { get; set; }
        public string TporqueEstudiar { get; set; }
        public int? Ceducativo { get; set; }
        public string Tdireccion { get; set; }
        public int? Cciudad { get; set; }
        public int? Cpais { get; set; }
        public int? Cdepartamento { get; set; }
    }
}
