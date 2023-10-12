using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TTablaDatum
    {
        public string Dgrupo { get; set; }
        public int? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public string Cingreso { get; set; }
        public string Dpersona { get; set; }
        public string Speriodo { get; set; }
        public int? Nsecuencia { get; set; }
        public string Scurso { get; set; }
        public string Dcurso { get; set; }
        public int? NCh { get; set; }
        public int? NCredito { get; set; }
        public int? GtipoAprobacion { get; set; }
        public string TexamenFinal { get; set; }
        public int? GtipoCredito { get; set; }
        public int? Notas { get; set; }
        public decimal? NporcAsistencia { get; set; }
        public int? EsUltimo { get; set; }
        public string TsituacionDisciplina { get; set; }
        public int? NpuntajeFinalMateria { get; set; }
        public int? GtipoCreditoU { get; set; }
        public int? Ndivisor { get; set; }
        public int? Ccurso { get; set; }
        public int? GtipoNotaUltima { get; set; }
        public int? NmaxParametro { get; set; }
        public int? Nparametro { get; set; }
        public int? NoportunidadNota { get; set; }
        public int? Npagina { get; set; }
        public int? NdGtipoNotaEs { get; set; }
        public int? NdParcialFijo { get; set; }
        public int? NdNotaEsta { get; set; }
        public int? NdNotaEvol { get; set; }
        public int? NdValorDiv { get; set; }
        public int? NdEvaluacionNotaEvol { get; set; }
        public string TsituacionNotaEvol { get; set; }
        public string CertifSperiodo { get; set; }
        public DateTime? DtMatCer { get; set; }
        public DateTime? DtInicioPerCer { get; set; }
        public int NdataFila { get; set; }
    }
}
