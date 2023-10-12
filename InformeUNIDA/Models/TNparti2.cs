using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TNparti2
    {
        public string Dgrupo { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public string Cingreso { get; set; }
        public string Dpersona { get; set; }
        public string Speriodo { get; set; }
        public short? Nsecuencia { get; set; }
        public string Scurso { get; set; }
        public string Dcurso { get; set; }
        public short? NCh { get; set; }
        public short NCredito { get; set; }
        public short GtipoAprobacion { get; set; }
        public string TexamenFinal { get; set; }
        public short? GtipoCredito { get; set; }
        public decimal NporcAsistencia { get; set; }
        public int? EsUltimo { get; set; }
        public string TsituciacionDisciplina { get; set; }
        public decimal? NpromedioPuntaje { get; set; }
        public short? GtipoCreditoU { get; set; }
        public int Ndivisor { get; set; }
        public short Ccurso { get; set; }
        public int GtipoNota { get; set; }
        public int? NordenNota { get; set; }
        public decimal? Nnota { get; set; }
        public int NacumuladoHastaNota { get; set; }
        public int NpunPar { get; set; }
    }
}
