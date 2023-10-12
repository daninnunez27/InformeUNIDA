using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class BloqueCursoRegistroEvaluacionH
    {
        public int Cregistro { get; set; }
        public int Ccurso { get; set; }
        public int Cbloque { get; set; }
        public int GtipoNota { get; set; }
        public int? CprofesorRegistro { get; set; }
        public DateTime? Fexamen { get; set; }
        public DateTime? FdigitaDesde { get; set; }
        public DateTime? FdigitaHasta { get; set; }
        public string Comentario { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public DateTime? FexamenAve { get; set; }
        public DateTime? FexamenAve2 { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public int? AutorizacionRegistroNota { get; set; }
        public string Cautorizacion { get; set; }
        public DateTime? FechaAutorizacionRegistroNota { get; set; }
        public string Tipo { get; set; }
        public DateTime? Fauditoria { get; set; }
    }
}
