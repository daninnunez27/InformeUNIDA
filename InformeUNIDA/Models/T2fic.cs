using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class T2fic
    {
        public int Cinstitucion { get; set; }
        public int Cprograma { get; set; }
        public short? Cperiodo { get; set; }
        public int? Calumno { get; set; }
        public short? Ccurso { get; set; }
        public int? Cbloque { get; set; }
        public int Gprogramado { get; set; }
        public int Gestado { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime Fmodificacion { get; set; }
        public int? Nvez { get; set; }
        public int? Tvalida { get; set; }
        public short? Ncredito { get; set; }
        public int Gcondicion { get; set; }
        public short? Nteoria { get; set; }
        public short? Npractica { get; set; }
        public short? Nlaboratorio { get; set; }
        public int? NvezReal { get; set; }
        public int? Nciclo { get; set; }
        public int? GautorizaInasis { get; set; }
        public int? NasistenciaProgramada { get; set; }
        public int? Nfalta { get; set; }
        public int? Njustifica { get; set; }
        public int? Pfalta { get; set; }
        public int? Pasistencia { get; set; }
        public int? NvecesRetiro { get; set; }
        public int? FretiroCurso { get; set; }
        public int? CcurriculaFuente { get; set; }
        public int? Nasistencia { get; set; }
    }
}
