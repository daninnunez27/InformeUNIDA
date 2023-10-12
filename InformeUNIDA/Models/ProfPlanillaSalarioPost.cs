using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class ProfPlanillaSalarioPost
    {
        public short Registro { get; set; }
        public short Cplanilla { get; set; }
        public short? Cinstitucion { get; set; }
        public short? Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public short? Ccarrera { get; set; }
        public short? Ccurso { get; set; }
        public short? Cprofesor { get; set; }
        public string NroCheque { get; set; }
        public string Comentario1 { get; set; }
        public string Comentario2 { get; set; }
        public decimal? HorasAsistidas { get; set; }
        public decimal? HorasCurricula { get; set; }
        public decimal? HorasReales { get; set; }
        public decimal? HorasPagadas { get; set; }
        public decimal? NmontoHora { get; set; }
        public decimal? NmontoNetoPagar { get; set; }
        public short? Gestado { get; set; }
        public string Mensaje { get; set; }
        public short? Aprobado { get; set; }
        public short? EstadoRegistro { get; set; }
        public string Tobservacion { get; set; }
        public string Ccreacion { get; set; }
        public DateTime? Fcreacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public string Cprocesopago { get; set; }
        public DateTime? Fprocesopago { get; set; }
        public string Cpago { get; set; }
        public DateTime? Fpago { get; set; }
        public string CmodificacionCheque { get; set; }
        public DateTime? FmodificacionCheque { get; set; }

        public virtual ConfigurarPlanillaPosgrado CplanillaNavigation { get; set; }
    }
}
