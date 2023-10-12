using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class CurriculaCursoH
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Ccurricula { get; set; }
        public short Ccurso { get; set; }
        public short? Nciclo { get; set; }
        public short? NcreditoMinimo { get; set; }
        public short? Gcondicion { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Ncadena { get; set; }
        public short? Norden { get; set; }
        public string Dcurso { get; set; }
        public string Scurso { get; set; }
        public decimal? Ncredito { get; set; }
        public short? Nteoria { get; set; }
        public short? Npractica { get; set; }
        public short? Nlaboratorio { get; set; }
    }
}
