using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SumRecordAlumno
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Calumno { get; set; }
        public short Ccarrera { get; set; }
        public string Cingreso { get; set; }
        public int Cpersona { get; set; }
        public string Dmodalidad { get; set; }
        public short CperiodoIng { get; set; }
        public short CperiodoSum { get; set; }
        public short CcurriculaSum { get; set; }
        public short NcreMatric { get; set; }
        public short NcreAprob { get; set; }
        public short NcreOblig { get; set; }
        public short NcreElect { get; set; }
        public short NcreConval { get; set; }
        public short NcicloMatric { get; set; }
        public decimal NcicloEquiv { get; set; }
        public short NcreProm { get; set; }
        public short NcursoProm { get; set; }
        public decimal? Nponderado { get; set; }
        public short? Npuesto { get; set; }
        public short? CperiodoPuesto { get; set; }
        public short Nalumnos { get; set; }
        public short NcursoMatric { get; set; }
        public short NcursoAprob { get; set; }
        public short NcursoOblig { get; set; }
        public short NcursoElect { get; set; }
        public short NcursoAprob1 { get; set; }
        public short NcursoAprob2 { get; set; }
        public short NcursoAprob3 { get; set; }
        public short NcursoConval { get; set; }
        public decimal PcursoAprob { get; set; }
        public decimal PcursoAprob1 { get; set; }
        public decimal PcursoAprob2 { get; set; }
        public decimal PcursoAprob3 { get; set; }
        public decimal PcursoConval { get; set; }
        public short NcursoPend2 { get; set; }
        public short NcursoPend3 { get; set; }
        public short NpromRango1 { get; set; }
        public short NpromRango2 { get; set; }
        public short NpromRango3 { get; set; }
        public decimal PpromRango1 { get; set; }
        public decimal PpromRango2 { get; set; }
        public decimal PpromRango3 { get; set; }
        public short? NcursoDesaprob { get; set; }
        public short? NcursoDesaprob1 { get; set; }
        public short? NcursoDesaprob2 { get; set; }
        public short? NcursoDesaprob3 { get; set; }
        public decimal? PcursoDesaprob { get; set; }
        public decimal? PcursoDesaprob1 { get; set; }
        public decimal? PcursoDesaprob2 { get; set; }
        public decimal? PcursoDesaprob3 { get; set; }
        public short? NcursoObMax { get; set; }
        public short? NcursoObMin { get; set; }
        public short NcalAvance { get; set; }
        public short NcalRanking { get; set; }
        public short NcalRendim { get; set; }
        public short NcalDisper { get; set; }
        public short NcalTotal { get; set; }
        public string Dsegmento { get; set; }
        public string EstadoActual { get; set; }
        public short? Ceducativo1 { get; set; }
        public short? Ceducativo2 { get; set; }
    }
}
