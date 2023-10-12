using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class PeriodoH
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public string Dperiodo { get; set; }
        public string Speriodo { get; set; }
        public DateTime? Finicio { get; set; }
        public DateTime? Ffinal { get; set; }
        public short? Nsemana { get; set; }
        public short? Gestado { get; set; }
        public short? Ncreditomax { get; set; }
        public short? Ncreditomin { get; set; }
        public short? GtipoPeriodo { get; set; }
        public string Tobservacion { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Chorario { get; set; }
        public short? GclasePeriodo { get; set; }
        public DateTime? Faaper { get; set; }
        public string Nperio { get; set; }
        public string Svigen { get; set; }
        public short? Nsecuencia { get; set; }
        public DateTime? FinicioVigencia { get; set; }
        public DateTime? FfinalVigencia { get; set; }
        public short Gvisible { get; set; }
        public DateTime? FcierreMatricula { get; set; }
        public DateTime? FinicioMatriWeb { get; set; }
        public DateTime? FcierreMatriWeb { get; set; }
        public short? DiasMatriWeb { get; set; }
        public DateTime? HoraMatriWeb { get; set; }
        public string NlibroCertificado { get; set; }
        public string DfechaCertificado { get; set; }
        public string Scorreo { get; set; }
        public int? NgrupoPeriodo { get; set; }
        public int? Clog { get; set; }
    }
}
