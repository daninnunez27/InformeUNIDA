using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class SumSeguimAlu
    {
        public short Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public int Cperiodo { get; set; }
        public string Speriodo { get; set; }
        public short Nsecuencia { get; set; }
        public int Ccarrera { get; set; }
        public string Dcarrera { get; set; }
        public string Scarrera { get; set; }
        public int Ceducativo { get; set; }
        public string Deducativo { get; set; }
        public string Gclasificacion { get; set; }
        public string Gcategoria { get; set; }
        public int CperiodoIng { get; set; }
        public string SperiodoIng { get; set; }
        public short NsecuenciaIng { get; set; }
        public int? Gmodalidad { get; set; }
        public string Dmodalidad { get; set; }
        public short? NcicloEquiv { get; set; }
        public string DcicloEquiv { get; set; }
        public string Cingreso { get; set; }
        public int Calumno { get; set; }
        public int Cpersona { get; set; }
        public string Dpersona { get; set; }
        public string Ntelefono1 { get; set; }
        public string Ntelefono2 { get; set; }
        public string Ntelefono3 { get; set; }
        public short Gcondicion { get; set; }
        public string Dcondicion { get; set; }
        public short Gestado { get; set; }
        public string Destado { get; set; }
        public decimal? Nponderado { get; set; }
        public decimal? Nacumulado { get; set; }
        public short? Ncredito { get; set; }
        public short? NcreditoAcum { get; set; }
        public string Snuevo { get; set; }
        public string Segresado { get; set; }
        public string Sexpulsado { get; set; }
        public string SretiroDef { get; set; }
        public string Sdesertor { get; set; }
        public string Srecuperado { get; set; }
        public string SretiroPer { get; set; }
        public string Ssuspendido { get; set; }
        public string ScambioCarre { get; set; }
        public int? CcarreraOut { get; set; }
        public string Striquero { get; set; }
        public string Sbiquero { get; set; }
        public string SquintoSup { get; set; }
        public string StercioSup { get; set; }
    }
}
