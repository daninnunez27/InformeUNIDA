using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PlanillaResuman
    {
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int Cplanilla { get; set; }
        public int? Cdetalle { get; set; }
        public int Cperiodo { get; set; }
        public int? Cpersona { get; set; }
        public int Cprofesor { get; set; }
        public decimal? HorasProgramadas { get; set; }
        public decimal? Nhoras { get; set; }
        public decimal? Nadicionales { get; set; }
        public decimal? Nexamenavs { get; set; }
        public decimal? Nexamenpfs { get; set; }
        public int? MinTarde { get; set; }
        public int? MinAntes { get; set; }
        public int? Nfaltas { get; set; }
        public string GtipoPlanilla { get; set; }
        public decimal? Ingbruto { get; set; }
        public decimal? Egrbruto { get; set; }
        public decimal? Ibruto { get; set; }
        public decimal? Iexavs { get; set; }
        public decimal? Iexpfs { get; set; }
        public decimal? Apagarnor { get; set; }
        public decimal? Apagaravs { get; set; }
        public decimal? Apagarpfs { get; set; }
        public decimal? Ingapagarnor { get; set; }
        public decimal? Aguibruto { get; set; }
        public string Comentario1 { get; set; }
        public string Comentario2 { get; set; }
        public string Nrocheque { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
