using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class FuncionarioWebActividadesH
    {
        public int? Cobjeto { get; set; }
        public string Semana { get; set; }
        public string Atencion { get; set; }
        public string Descripcion { get; set; }
        public string Susuario { get; set; }
        public DateTime? Fcreacion { get; set; }
        public int? Estado { get; set; }
        public string Periodo { get; set; }
        public DateTime? FechaActividad { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int? Clog { get; set; }
    }
}
