using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class DocenteGrupoCursoConfig
    {
        public int IdGrupo { get; set; }
        public string Dgrupo { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Cperiodo { get; set; }
        public int? Cprofesor { get; set; }
        public int? Cbloque { get; set; }
        public int? Ccurso { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
