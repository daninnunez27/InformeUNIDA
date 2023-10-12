using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfPlanillaSalarioTesi
    {
        public int Registro { get; set; }
        public int? Cplanilla { get; set; }
        public int? Cinstitucion { get; set; }
        public int? Cprograma { get; set; }
        public int? Calumno { get; set; }
        public DateTime? TesisFecha { get; set; }
        public int? NroActa { get; set; }
        public int? AnioActa { get; set; }
        public int? NroMesa { get; set; }
        public int? Cprofesor { get; set; }
        public string GtipoPlanilla { get; set; }
        public string NroCheque { get; set; }
        public string Comentario1 { get; set; }
        public string Comentario2 { get; set; }
        public decimal? NmontoNetoPagar { get; set; }
        public int? FlagAprobacionPago { get; set; }
        public int? Gestado { get; set; }
        public int? EstadoPago { get; set; }
        public string Tipo { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
