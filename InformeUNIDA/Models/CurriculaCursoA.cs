using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CurriculaCursoA
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Ccurricula { get; set; }
        public short Ccurso { get; set; }
        public short? Nciclo { get; set; }
        public decimal? NcreditoMinimo { get; set; }
        public short? Gcondicion { get; set; }
        public short? Gestado { get; set; }
        public short? Ncadena { get; set; }
        public short? Norden { get; set; }
        public string Dcurso { get; set; }
        public string Scurso { get; set; }
        public string DcursoCertificado { get; set; }
        public short? Ncredito { get; set; }
        public short? NcreditoReal { get; set; }
        public short? Nteoria { get; set; }
        public short? Npractica { get; set; }
        public short? Nlaboratorio { get; set; }
        public short? Gcobra { get; set; }
        public decimal? PorcInasistencia { get; set; }
        public short? Ginasistencia { get; set; }
        public short? NvezMaxima { get; set; }
        public short? Nfamilia { get; set; }
        public short? GtipoCredito { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
    }
}
