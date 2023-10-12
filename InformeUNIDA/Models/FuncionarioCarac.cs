using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class FuncionarioCarac
    {
        public int Cfcarac { get; set; }
        public int? NdocIdentidad { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string FNac { get; set; }
        public string Nacionalidad { get; set; }
        public string Domicilio { get; set; }
        public string Departamento { get; set; }
        public string Profesion { get; set; }
        public string FEntrada { get; set; }
        public int? Nautoridad { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Estado { get; set; }
    }
}
