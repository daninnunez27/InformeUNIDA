using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class TpaseF
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Calumno { get; set; }
        public short Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public short? Gprogramado { get; set; }
        public short? Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Nvez { get; set; }
        public string Tvalida { get; set; }
        public short? Ncredito { get; set; }
        public short? Gcondicion { get; set; }
        public short? Nteoria { get; set; }
        public short? Npractica { get; set; }
        public short? Nlaboratorio { get; set; }
        public short? NvezReal { get; set; }
        public short? Nciclo { get; set; }
        public short? GautorizaInasis { get; set; }
        public short? NasistenciaProgramada { get; set; }
        public short? Nfalta { get; set; }
        public short? Njustifica { get; set; }
        public decimal? Pfalta { get; set; }
        public decimal? Pasistencia { get; set; }
        public short? NvecesRetiro { get; set; }
        public DateTime? FretiroCurso { get; set; }
        public int? CcurriculaFuente { get; set; }
        public short? Nasistencia { get; set; }
        public DateTime? FprimeraMatricula { get; set; }
        public DateTime? FultimaMatricula { get; set; }
    }
}
