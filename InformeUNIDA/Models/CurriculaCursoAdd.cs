using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CurriculaCursoAdd
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public int Ccurricula { get; set; }
        public short Ccurso { get; set; }
        public int Nciclo { get; set; }
        public int NcreditoMinimo { get; set; }
        public int Gcondicion { get; set; }
        public int Gestado { get; set; }
        public int? Ncadena { get; set; }
        public int? Norden { get; set; }
        public string Dcurso { get; set; }
        public string Scurso { get; set; }
        public string DcursoCertificado { get; set; }
        public short? Ncredito { get; set; }
        public short? NcreditoReal { get; set; }
        public short? Nteoria { get; set; }
        public short? Npractica { get; set; }
        public short? Nlaboratorio { get; set; }
        public short Gcobra { get; set; }
        public decimal? PorcInasistencia { get; set; }
        public short? Ginasistencia { get; set; }
        public short? NvezMaxima { get; set; }
        public short? Nfamilia { get; set; }
        public short? GtipoCredito { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public int Mas { get; set; }
        public short Ccarrera { get; set; }
        public short Cespecialidad { get; set; }
        public string Dcurricula { get; set; }
        public string Scurricula { get; set; }
    }
}
