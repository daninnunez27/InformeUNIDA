using System;
using System.Collections.Generic;

#nullable disable

namespace InformeUNIDA.Models
{
    public partial class EventoAlumno
    {
        public short Cinstitucion { get; set; }
        public short Cprograma { get; set; }
        public short Cperiodo { get; set; }
        public short Cevento { get; set; }
        public DateTime Fevento { get; set; }
        public short Ccurso { get; set; }
        public int Cbloque { get; set; }
        public short Caula { get; set; }
        public string Cfila { get; set; }
        public int Calumno { get; set; }
        public string Cmodificacion { get; set; }
        public DateTime? Fmodificacion { get; set; }
        public short? Nfalta { get; set; }
        public short? Njustifica { get; set; }
        public short? Grezagado { get; set; }
        public short? GasistRezagado { get; set; }
        public DateTime? Fsolicitud { get; set; }
        public string Gcontrol { get; set; }
    }
}
