using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfPlanillaSalarioPre
    {
        public short Registro { get; set; }
        public short? Reporte { get; set; }
        public short? Cplanilla { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public short? Ccarrera { get; set; }
        public short? Ccordinadora { get; set; }
        public short? Ccurso { get; set; }
        public int? Cprofesor { get; set; }
        public short? Cconcepto { get; set; }
        public string Concepto { get; set; }
        public short? CargaHoraria { get; set; }
        public string GtipoPlanilla { get; set; }
        public decimal? NmontoHora { get; set; }
        public decimal? Nmonto { get; set; }
        public decimal? TipoPlanillaDescuento { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? NmontoNetoPagar { get; set; }
        public short? Gestado { get; set; }
        public string Tobservacion { get; set; }
        public string Nrocheque { get; set; }
        public string Comentario1 { get; set; }
        public string Comentario2 { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string CmodificacionCheque { get; set; }
        public DateTime? FmodificacionCheque { get; set; }
    }
}
