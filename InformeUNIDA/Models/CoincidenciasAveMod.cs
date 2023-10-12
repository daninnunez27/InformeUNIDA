using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CoincidenciasAveMod
    {
        public int Calumno { get; set; }
        public int Cperiodo { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public int GtipoNota { get; set; }
        public DateTime? FechaExamen { get; set; }
        public DateTime? Hexamen { get; set; }
        public DateTime? FechaAve { get; set; }
        public int? Cprofesor { get; set; }
        public int? Solicitado { get; set; }
        public int? Autorizado { get; set; }
        public string UsuarioAutoriza { get; set; }
        public DateTime? Fcreacion { get; set; }
        public int? Revocado { get; set; }
        public int? MarcaSys { get; set; }
        public DateTime? Fsolicitado { get; set; }
        public DateTime? Fultimamod { get; set; }
    }
}
