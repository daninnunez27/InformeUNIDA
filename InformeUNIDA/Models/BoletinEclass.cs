using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BoletinEclass
    {
        public int IdBoletin { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cfacultad { get; set; }
        public int? Ccarrera { get; set; }
        public int? ModuloAlumno { get; set; }
        public int? ModuloProfesor { get; set; }
        public int? ModuloFuncionario { get; set; }
        public int? ModuloEgresado { get; set; }
        public int? ModuloPadres { get; set; }
        public byte[] Boletin { get; set; }
        public string Tarchivo { get; set; }
        public DateTime? Finicio { get; set; }
        public DateTime? Ffinal { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Cmodificacion { get; set; }
        public string NombreArchivo { get; set; }
        public int? Estado { get; set; }
    }
}
