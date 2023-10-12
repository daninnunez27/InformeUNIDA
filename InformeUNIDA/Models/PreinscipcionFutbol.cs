using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PreinscipcionFutbol
    {
        public int Cpreinscripcion { get; set; }
        public string Cinstitucion { get; set; }
        public string Cprograma { get; set; }
        public string TipoParticipante { get; set; }
        public string Cperiodo { get; set; }
        public string Cfacultad { get; set; }
        public string Ccarrera { get; set; }
        public int? Anio { get; set; }
        public string Nombre { get; set; }
        public string Ci { get; set; }
        public int? Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
    }
}
