using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class AsistWebAlumno
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public int Cbloque { get; set; }
        public short Ccurso { get; set; }
        public short GtipoHora { get; set; }
        public DateTime Fasistencia { get; set; }
        public int Calumno { get; set; }
        public short? GtipoAsistencia { get; set; }
        public short Nfalta { get; set; }
        public short Njustifica { get; set; }
        public DateTime? Hinicio { get; set; }
        public DateTime? Hfinal { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public DateTime? FasistenciaMod { get; set; }
    }
}
