using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TNcRecalCer
    {
        public string Dprograma { get; set; }
        public string Speriodo { get; set; }
        public string Cingreso { get; set; }
        public string Dpersona { get; set; }
        public string Scurso { get; set; }
        public string Dcurso { get; set; }
        public short? FGestado { get; set; }
        public decimal? NpuntajeHistorico { get; set; }
        public short EsAprobadoHistorico { get; set; }
        public decimal? NpuntajeRecalculo { get; set; }
        public string Detalle { get; set; }
        public decimal? Av1 { get; set; }
        public decimal? Av2 { get; set; }
        public decimal? Pf1 { get; set; }
        public decimal? Pf2 { get; set; }
        public decimal? Pe { get; set; }
        public decimal? Tp { get; set; }
        public decimal? Pf { get; set; }
        public string Grupo { get; set; }
        public short? GtipoCredito { get; set; }
        public short? Ccarrera { get; set; }
        public short? CcarreraEstado { get; set; }
        public string Dcarrera { get; set; }
        public short GtipoAprobacion { get; set; }
        public int Calumno { get; set; }
        public short Cperiodo { get; set; }
        public int Cpersona { get; set; }
        public short Ccurso { get; set; }
    }
}
