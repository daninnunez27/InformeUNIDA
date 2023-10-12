using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ConvenioH
    {
        public int Cconvenio { get; set; }
        public string Dconvenio { get; set; }
        public int? Ceducativo { get; set; }
        public int? Ggrupo { get; set; }
        public int? Gvia { get; set; }
        public int? GtipoDuracion { get; set; }
        public DateTime? Fincio { get; set; }
        public DateTime? Ffinal { get; set; }
        public int? Nalumno { get; set; }
        public int? Npotenciales { get; set; }
        public string Tfin { get; set; }
        public string Tduracion { get; set; }
        public string Tofrecemos { get; set; }
        public string Trecibimos { get; set; }
        public string Tcomentario { get; set; }
        public string GtipoConvenio { get; set; }
        public DateTime? Ffirma { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Tipo { get; set; }
        public DateTime Fauditoria { get; set; }
    }
}
